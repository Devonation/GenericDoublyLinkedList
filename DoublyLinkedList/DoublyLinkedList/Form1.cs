using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace DoublyLinkedList
{
    public partial class Form1 : Form
    {
        private Thread playThread = null;
        private Track playingTrack = null;
        private bool endTrack = false;
        private bool paused = false;
        private bool playing = false;
        private static CustomTime customTime = new(1, 45);
        private static Track firstTrack = new("House", "Devon", customTime);
        CustomDoublyLinkedList<Track> originalTracks = new(firstTrack);
        public Form1()
        {
            InitializeComponent();

            FormClosing += Form1_FormClosing;
            dgv_trackTable.RowsAdded += dgv_trackTable_RowsAdded;
            dgv_trackTable.RowsRemoved += dgv_trackTable_RowsRemoved;

            columnsDGV();
            populateDGV(originalTracks);
            backgroundDGV();
        }
        private void backgroundDGV()
        {
            dgv_trackTable.BackgroundColor = Color.CadetBlue;
            foreach (DataGridViewRow row in dgv_trackTable.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.CadetBlue;
                row.DefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            }
        }
        private void columnsDGV()
        {
            dgv_trackTable.Columns.Add("No", "No");
            dgv_trackTable.Columns.Add("Title", "Title");
            dgv_trackTable.Columns.Add("Artist", "Artist");
            dgv_trackTable.Columns.Add("Duration", "Duration");

            int totalWidth = dgv_trackTable.Width - 1;

            double noPercentage = 0.1;
            double titlePercentage = 0.45;
            double artistPercentage = 0.25;
            double durationPercentage = 0.2;

            dgv_trackTable.Columns[0].Width = (int)(totalWidth * noPercentage);
            dgv_trackTable.Columns[1].Width = (int)(totalWidth * titlePercentage);
            dgv_trackTable.Columns[2].Width = (int)(totalWidth * artistPercentage);
            dgv_trackTable.Columns[3].Width = (int)(totalWidth * durationPercentage);
        }
        private void fillRow(int rowIndex, int no, Track tempTrack)
        {
            dgv_trackTable.Rows[rowIndex].Cells[0].Value = no;
            dgv_trackTable.Rows[rowIndex].Cells[1].Value = tempTrack.Title;
            dgv_trackTable.Rows[rowIndex].Cells[2].Value = tempTrack.Artist;
            dgv_trackTable.Rows[rowIndex].Cells[3].Value = $"{tempTrack.Duration}";
        }
        private void populateDGV(CustomDoublyLinkedList<Track> playlist)
        {
            dgv_trackTable.Rows.Clear();
            DoublyNode<Track> current = playlist.Head;
            int no = 0;

            if (current != null)
            {
                do
                {
                    Track tempTrack = current.Data;
                    int rowIndex = dgv_trackTable.Rows.Add();
                    no++;
                    fillRow(rowIndex, no, tempTrack);
                    if (current.Next != null)
                    {
                        current = current.Next;
                    }
                    else
                    {
                        break;
                    }
                } while (true);
            }
        }
        private void bt_search_Click(object sender, EventArgs e)
        {
            dgv_trackTable.Rows.Clear();
            Track tempTrack = originalTracks.SearchItem(txb_searchTitle.Text);
            if (!txb_searchTitle.Text.Equals(string.Empty))
            {
                if (tempTrack != default)
                {
                    int rowIndex = dgv_trackTable.Rows.Add();
                    fillRow(rowIndex, 1, tempTrack);
                }
            }
            else
            {
                populateDGV(originalTracks);
            }
        }

        private void bt_trackAdd_Click(object sender, EventArgs e)
        {
            string trackName = txb_trackName.Text;
            string trackArtist = txb_trackArtist.Text;
            string trackDuration = txb_trackDuration.Text;

            if (!trackName.Equals(string.Empty) || !trackArtist.Equals(string.Empty) || !trackDuration.Equals(string.Empty))
            {
                CustomTime customTimeTrackDuration = new(trackDuration);
                originalTracks.AppendItem(new Track(trackName, trackArtist, customTimeTrackDuration));
                populateDGV(originalTracks);

                txb_trackName.Clear();
                txb_trackArtist.Clear();
                txb_trackDuration.Clear();
            }
        }

        private void dgv_trackTable_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            backgroundDGV();
        }

        private void dgv_trackTable_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            backgroundDGV();
        }
        private Track retrieveCurrentRowData()
        {
            if (originalTracks.Count > 0)
            {
                DataGridViewRow selectedRow = dgv_trackTable.SelectedRows[0];
                string title = selectedRow.Cells[1].Value.ToString();
                //string artist = selectedRow.Cells[2].Value.ToString();
                //CustomTime duration = new(selectedRow.Cells[3].Value.ToString());

                return originalTracks.SearchItem(title);
            }
            else
            {
                return null;
            }
        }
        private void bt_playTrack_Click(object sender, EventArgs e)
        {
            paused = false;
            Track currentTrack = retrieveCurrentRowData();
            if (playingTrack != null)
            {
                if (currentTrack.Title.Equals(playingTrack.Title))
                {
                    if (!playing)
                    {
                        if (currentTrack != null)
                        {
                            playingTrack = currentTrack;
                            playThread = new(() => PlayingTrack(currentTrack));
                            playThread.Start();
                            playing = true;
                        }
                    }
                }
                else
                {
                    endTrack = true;
                    while (endTrack)
                    {

                    }
                    StartNewTrack(currentTrack);
                }
            }
            else
            {
                StartNewTrack(currentTrack);
            }
        }
        private void StartNewTrack(Track currentTrack)
        {
            pbar_currentTrack.Value = 0;
            if (currentTrack != null)
            {
                playingTrack = currentTrack;
                playThread = new(() => PlayingTrack(currentTrack));
                playThread.Start();
                playing = true;
            }
        }
        private void PlayingTrack(Track currentTrack)
        {
            int elapsedSeconds = 0;
            CustomTime duration = currentTrack.Duration;
            int totalSeconds = duration.TotalSeconds();
            while (elapsedSeconds < totalSeconds && !endTrack)
            {
                if (!paused)
                {
                    Thread.Sleep(1000);
                    elapsedSeconds++;

                    if (InvokeRequired)
                    {
                        if (!endTrack)
                        {
                            Invoke(new Action(() =>
                            {
                                CustomTime currentTime = new(elapsedSeconds);
                                lbl_trackTimerCurrent.Text = $"{currentTime}";
                                lbl_trackTimerEnd.Text = $"{duration}";
                                pbar_currentTrack.Minimum = 0;
                                pbar_currentTrack.Maximum = totalSeconds;
                                if (!endTrack)
                                {
                                    pbar_currentTrack.Increment(1);
                                }
                            }));
                        }
                    }
                    else
                    {
                        lbl_trackTimerCurrent.Text = "0:00";
                    }
                }
            }
            endTrack = false;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            endTrack = true;
        }

        private void bt_shuffleTracks_Click(object sender, EventArgs e)
        {
            CustomDoublyLinkedList<Track> shuffledTracks = new();
            int step = 0;
            if (originalTracks.Head != null)
            {
                if (originalTracks.Head.Next != null)
                {
                    DoublyNode<Track> current = originalTracks.Head.Next;
                    while (step < originalTracks.Count)
                    {
                        int random = new Random().Next(0, 2);

                        if (random == 0)
                        {
                            shuffledTracks.PrependItem(current.Data);
                        }
                        else
                        {
                            shuffledTracks.AppendItem(current.Data);
                        }
                        if (current.Next != null)
                        {
                            current = current.Next;
                        }
                        else
                        {
                            break;
                        }
                    }
                    populateDGV(shuffledTracks);
                }
            }
            
        }

        private void bt_pauseTrack_Click(object sender, EventArgs e)
        {
            paused = true;
        }
        private void ResetCurrentTrackUI()
        {
            pbar_currentTrack.Value = 0;
            lbl_trackTimerCurrent.Text = "0:00";
            lbl_trackTimerEnd.Text = "0:00";
        }
        private void bt_deleteTrack_Click(object sender, EventArgs e)
        {
            Track? currentTrack = retrieveCurrentRowData();
            if (currentTrack != null)
            {
                originalTracks.RemoveItem(currentTrack);
                populateDGV(originalTracks);
            }
            ResetCurrentTrackUI();
        }
    }
}
