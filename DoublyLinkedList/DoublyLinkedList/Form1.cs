namespace DoublyLinkedList
{
    public partial class Form1 : Form
    {
        private static CustomTime customTime = new(1, 45);
        private static Track firstTrack = new("House", "Devon", customTime);
        CustomDoublyLinkedList<Track> tracks = new(firstTrack);
        public Form1()
        {
            InitializeComponent();
            dgv_trackTable.Columns.Add("No", "No");
            dgv_trackTable.Columns.Add("Title", "Title");
            dgv_trackTable.Columns.Add("Artist", "Artist");
            dgv_trackTable.Columns.Add("Duration", "Duration");

            columnWidthDGV();
            populateDGV();
            backgroundDGV();

            dgv_trackTable.RowsAdded += dgv_trackTable_RowsAdded;
            dgv_trackTable.RowsRemoved += dgv_trackTable_RowsRemoved;
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
        private void columnWidthDGV()
        {
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
            dgv_trackTable.Rows[rowIndex].Cells[3].Value = $"{tempTrack.Duration.Minutes}:{tempTrack.Duration.Seconds}";
        }
        private void populateDGV()
        {
            dgv_trackTable.Rows.Clear();
            DoublyNode<Track> current = tracks.Head;
            int no = 0;

            Track tempTrack = current.Data;
            int rowIndex = dgv_trackTable.Rows.Add();
            no++;
            fillRow(rowIndex, no, tempTrack);

            while (current.Next != null)
            {
                current = current.Next;
                tempTrack = current.Data;
                rowIndex = dgv_trackTable.Rows.Add();
                no++;
                fillRow(rowIndex, no, tempTrack);
            }
        }
        private void bt_search_Click(object sender, EventArgs e)
        {
            dgv_trackTable.Rows.Clear();
            Track tempTrack = tracks.SearchItem(txb_searchTitle.Text);
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
                populateDGV();
            }
        }

        private void bt_trackAdd_Click(object sender, EventArgs e)
        {
            string trackName = txb_trackName.Text;
            string trackArtist = txb_trackArtist.Text;
            string trackDuration = txb_trackDuration.Text;

            if (!trackName.Equals(string.Empty) || !trackArtist.Equals(string.Empty) || !trackDuration.Equals(string.Empty))
            {
                CustomTime customTimeTrackDuration = new CustomTime().ConvertFromStringToTime(trackDuration);
                tracks.AddItem(new Track(trackName, trackArtist, customTimeTrackDuration));
                populateDGV();

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
    }
}
