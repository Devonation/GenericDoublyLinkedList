﻿namespace DoublyLinkedList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lbl_enterName = new Label();
            txb_searchTitle = new TextBox();
            bt_search = new Button();
            dgv_trackTable = new DataGridView();
            txb_trackName = new TextBox();
            txb_trackArtist = new TextBox();
            txb_trackDuration = new TextBox();
            lbl_trackTitle = new Label();
            lbl_trackArtist = new Label();
            lbl_trackDuration = new Label();
            bt_trackAdd = new Button();
            pnl_right = new Panel();
            panel2 = new Panel();
            pnl_left = new Panel();
            bt_shuffleTracks = new Button();
            lbl_trackTimerCurrent = new Label();
            pbar_currentTrack = new ProgressBar();
            lbl_trackTimerEnd = new Label();
            bt_playTrack = new Button();
            img_currentTrack = new PictureBox();
            bt_pauseTrack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_trackTable).BeginInit();
            pnl_right.SuspendLayout();
            panel2.SuspendLayout();
            pnl_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)img_currentTrack).BeginInit();
            SuspendLayout();
            // 
            // lbl_enterName
            // 
            lbl_enterName.AutoSize = true;
            lbl_enterName.Location = new Point(38, 32);
            lbl_enterName.Name = "lbl_enterName";
            lbl_enterName.Size = new Size(69, 15);
            lbl_enterName.TabIndex = 0;
            lbl_enterName.Text = "Enter Name";
            // 
            // txb_searchTitle
            // 
            txb_searchTitle.Location = new Point(134, 29);
            txb_searchTitle.Name = "txb_searchTitle";
            txb_searchTitle.Size = new Size(198, 23);
            txb_searchTitle.TabIndex = 1;
            // 
            // bt_search
            // 
            bt_search.Location = new Point(357, 29);
            bt_search.Name = "bt_search";
            bt_search.Size = new Size(75, 23);
            bt_search.TabIndex = 4;
            bt_search.Text = "Search";
            bt_search.UseVisualStyleBackColor = true;
            bt_search.Click += bt_search_Click;
            // 
            // dgv_trackTable
            // 
            dgv_trackTable.AllowUserToResizeColumns = false;
            dgv_trackTable.AllowUserToResizeRows = false;
            dgv_trackTable.BackgroundColor = SystemColors.InactiveCaption;
            dgv_trackTable.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv_trackTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_trackTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_trackTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_trackTable.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgv_trackTable.EnableHeadersVisualStyles = false;
            dgv_trackTable.Location = new Point(32, 71);
            dgv_trackTable.MultiSelect = false;
            dgv_trackTable.Name = "dgv_trackTable";
            dgv_trackTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv_trackTable.RowHeadersVisible = false;
            dgv_trackTable.RowHeadersWidth = 51;
            dgv_trackTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_trackTable.ShowCellToolTips = false;
            dgv_trackTable.ShowEditingIcon = false;
            dgv_trackTable.Size = new Size(400, 250);
            dgv_trackTable.TabIndex = 5;
            // 
            // txb_trackName
            // 
            txb_trackName.Location = new Point(19, 94);
            txb_trackName.Name = "txb_trackName";
            txb_trackName.Size = new Size(165, 23);
            txb_trackName.TabIndex = 6;
            // 
            // txb_trackArtist
            // 
            txb_trackArtist.Location = new Point(19, 164);
            txb_trackArtist.Name = "txb_trackArtist";
            txb_trackArtist.Size = new Size(165, 23);
            txb_trackArtist.TabIndex = 7;
            // 
            // txb_trackDuration
            // 
            txb_trackDuration.Location = new Point(19, 239);
            txb_trackDuration.Name = "txb_trackDuration";
            txb_trackDuration.PlaceholderText = "mm:ss";
            txb_trackDuration.Size = new Size(84, 23);
            txb_trackDuration.TabIndex = 8;
            // 
            // lbl_trackTitle
            // 
            lbl_trackTitle.AutoSize = true;
            lbl_trackTitle.Location = new Point(19, 63);
            lbl_trackTitle.Name = "lbl_trackTitle";
            lbl_trackTitle.Size = new Size(29, 15);
            lbl_trackTitle.TabIndex = 9;
            lbl_trackTitle.Text = "Title";
            // 
            // lbl_trackArtist
            // 
            lbl_trackArtist.AutoSize = true;
            lbl_trackArtist.Location = new Point(19, 137);
            lbl_trackArtist.Name = "lbl_trackArtist";
            lbl_trackArtist.Size = new Size(35, 15);
            lbl_trackArtist.TabIndex = 10;
            lbl_trackArtist.Text = "Artist";
            // 
            // lbl_trackDuration
            // 
            lbl_trackDuration.AutoSize = true;
            lbl_trackDuration.Location = new Point(19, 212);
            lbl_trackDuration.Name = "lbl_trackDuration";
            lbl_trackDuration.Size = new Size(53, 15);
            lbl_trackDuration.TabIndex = 11;
            lbl_trackDuration.Text = "Duration";
            // 
            // bt_trackAdd
            // 
            bt_trackAdd.Location = new Point(109, 239);
            bt_trackAdd.Name = "bt_trackAdd";
            bt_trackAdd.Size = new Size(75, 23);
            bt_trackAdd.TabIndex = 12;
            bt_trackAdd.Text = "Add";
            bt_trackAdd.UseVisualStyleBackColor = true;
            bt_trackAdd.Click += bt_trackAdd_Click;
            // 
            // pnl_right
            // 
            pnl_right.BackColor = SystemColors.ActiveCaption;
            pnl_right.Controls.Add(txb_trackArtist);
            pnl_right.Controls.Add(bt_trackAdd);
            pnl_right.Controls.Add(txb_trackName);
            pnl_right.Controls.Add(lbl_trackDuration);
            pnl_right.Controls.Add(txb_trackDuration);
            pnl_right.Controls.Add(lbl_trackArtist);
            pnl_right.Controls.Add(lbl_trackTitle);
            pnl_right.Location = new Point(13, 12);
            pnl_right.Name = "pnl_right";
            pnl_right.Size = new Size(212, 352);
            pnl_right.TabIndex = 13;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(dgv_trackTable);
            panel2.Controls.Add(txb_searchTitle);
            panel2.Controls.Add(bt_search);
            panel2.Controls.Add(lbl_enterName);
            panel2.Location = new Point(230, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(464, 352);
            panel2.TabIndex = 14;
            // 
            // pnl_left
            // 
            pnl_left.BackColor = SystemColors.ActiveCaption;
            pnl_left.Controls.Add(bt_pauseTrack);
            pnl_left.Controls.Add(bt_shuffleTracks);
            pnl_left.Controls.Add(lbl_trackTimerCurrent);
            pnl_left.Controls.Add(pbar_currentTrack);
            pnl_left.Controls.Add(lbl_trackTimerEnd);
            pnl_left.Controls.Add(bt_playTrack);
            pnl_left.Controls.Add(img_currentTrack);
            pnl_left.Location = new Point(699, 12);
            pnl_left.Name = "pnl_left";
            pnl_left.Size = new Size(212, 352);
            pnl_left.TabIndex = 14;
            // 
            // bt_shuffleTracks
            // 
            bt_shuffleTracks.Location = new Point(53, 291);
            bt_shuffleTracks.Margin = new Padding(3, 2, 3, 2);
            bt_shuffleTracks.Name = "bt_shuffleTracks";
            bt_shuffleTracks.Size = new Size(82, 22);
            bt_shuffleTracks.TabIndex = 6;
            bt_shuffleTracks.Text = "Shuffle";
            bt_shuffleTracks.UseVisualStyleBackColor = true;
            bt_shuffleTracks.Click += bt_shuffleTracks_Click;
            // 
            // lbl_trackTimerCurrent
            // 
            lbl_trackTimerCurrent.AutoSize = true;
            lbl_trackTimerCurrent.Location = new Point(13, 195);
            lbl_trackTimerCurrent.Name = "lbl_trackTimerCurrent";
            lbl_trackTimerCurrent.Size = new Size(28, 15);
            lbl_trackTimerCurrent.TabIndex = 5;
            lbl_trackTimerCurrent.Text = "0:00";
            // 
            // pbar_currentTrack
            // 
            pbar_currentTrack.Location = new Point(13, 212);
            pbar_currentTrack.Margin = new Padding(3, 2, 3, 2);
            pbar_currentTrack.Name = "pbar_currentTrack";
            pbar_currentTrack.Size = new Size(187, 10);
            pbar_currentTrack.TabIndex = 4;
            // 
            // lbl_trackTimerEnd
            // 
            lbl_trackTimerEnd.AutoSize = true;
            lbl_trackTimerEnd.Location = new Point(169, 195);
            lbl_trackTimerEnd.Name = "lbl_trackTimerEnd";
            lbl_trackTimerEnd.Size = new Size(28, 15);
            lbl_trackTimerEnd.TabIndex = 3;
            lbl_trackTimerEnd.Text = "0:00";
            // 
            // bt_playTrack
            // 
            bt_playTrack.Location = new Point(23, 240);
            bt_playTrack.Margin = new Padding(3, 2, 3, 2);
            bt_playTrack.Name = "bt_playTrack";
            bt_playTrack.Size = new Size(82, 22);
            bt_playTrack.TabIndex = 2;
            bt_playTrack.Text = "Play";
            bt_playTrack.UseVisualStyleBackColor = true;
            bt_playTrack.Click += bt_playTrack_Click;
            // 
            // img_currentTrack
            // 
            img_currentTrack.Location = new Point(13, 18);
            img_currentTrack.Margin = new Padding(3, 2, 3, 2);
            img_currentTrack.Name = "img_currentTrack";
            img_currentTrack.Size = new Size(187, 165);
            img_currentTrack.TabIndex = 1;
            img_currentTrack.TabStop = false;
            // 
            // bt_pauseTrack
            // 
            bt_pauseTrack.Location = new Point(122, 238);
            bt_pauseTrack.Name = "bt_pauseTrack";
            bt_pauseTrack.Size = new Size(75, 23);
            bt_pauseTrack.TabIndex = 7;
            bt_pauseTrack.Text = "Pause";
            bt_pauseTrack.UseVisualStyleBackColor = true;
            bt_pauseTrack.Click += bt_pauseTrack_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 380);
            Controls.Add(pnl_left);
            Controls.Add(panel2);
            Controls.Add(pnl_right);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgv_trackTable).EndInit();
            pnl_right.ResumeLayout(false);
            pnl_right.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            pnl_left.ResumeLayout(false);
            pnl_left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)img_currentTrack).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_enterName;
        private TextBox txb_searchTitle;
        private Button bt_search;
        private DataGridView dgv_trackTable;
        private TextBox txb_trackName;
        private TextBox txb_trackArtist;
        private TextBox txb_trackDuration;
        private Label lbl_trackTitle;
        private Label lbl_trackArtist;
        private Label lbl_trackDuration;
        private Button bt_trackAdd;
        private Panel pnl_right;
        private Panel panel2;
        private Panel pnl_left;
        private PictureBox img_currentTrack;
        private Button bt_playTrack;
        private ProgressBar pbar_currentTrack;
        private Label lbl_trackTimerEnd;
        private Label lbl_trackTimerCurrent;
        private Button bt_shuffleTracks;
        private Button bt_pauseTrack;
    }
}
