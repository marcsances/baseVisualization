namespace visualizationPlugin
{
    partial class visualizationUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.videoPanel = new System.Windows.Forms.Panel();
            this.albumBox = new System.Windows.Forms.PictureBox();
            this.songAlbum = new Label2();
            this.songArtist = new Label2();
            this.songtitle = new Label2();
            this.songPos = new Label2();
            ((System.ComponentModel.ISupportInitialize)(this.albumBox)).BeginInit();
            this.SuspendLayout();
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 50;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // videoPanel
            // 
            this.videoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.videoPanel.BackColor = System.Drawing.Color.Transparent;
            this.videoPanel.Location = new System.Drawing.Point(20, 44);
            this.videoPanel.Name = "videoPanel";
            this.videoPanel.Size = new System.Drawing.Size(607, 306);
            this.videoPanel.TabIndex = 9;
            this.videoPanel.Click += new System.EventHandler(this.videoPanel_Click);
            // 
            // albumBox
            // 
            this.albumBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.albumBox.Location = new System.Drawing.Point(0, -80);
            this.albumBox.Name = "albumBox";
            this.albumBox.Size = new System.Drawing.Size(640, 640);
            this.albumBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.albumBox.TabIndex = 10;
            this.albumBox.TabStop = false;
            // 
            // songAlbum
            // 
            this.songAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.songAlbum.BackColor = System.Drawing.Color.Transparent;
            this.songAlbum.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.songAlbum.ForeColor = System.Drawing.Color.White;
            this.songAlbum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.songAlbum.Location = new System.Drawing.Point(17, 452);
            this.songAlbum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.songAlbum.Name = "songAlbum";
            this.songAlbum.Size = new System.Drawing.Size(611, 19);
            this.songAlbum.TabIndex = 7;
            this.songAlbum.Text = "Album";
            this.songAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.songAlbum.DoubleClick += new System.EventHandler(this.songAlbum_DoubleClick);
            // 
            // songArtist
            // 
            this.songArtist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.songArtist.BackColor = System.Drawing.Color.Transparent;
            this.songArtist.Font = new System.Drawing.Font("Open Sans", 12F);
            this.songArtist.ForeColor = System.Drawing.Color.White;
            this.songArtist.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.songArtist.Location = new System.Drawing.Point(16, 420);
            this.songArtist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.songArtist.Name = "songArtist";
            this.songArtist.Size = new System.Drawing.Size(611, 32);
            this.songArtist.TabIndex = 6;
            this.songArtist.Text = "Artist";
            this.songArtist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.songArtist.DoubleClick += new System.EventHandler(this.songArtist_DoubleClick);
            // 
            // songtitle
            // 
            this.songtitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.songtitle.BackColor = System.Drawing.Color.Transparent;
            this.songtitle.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.songtitle.ForeColor = System.Drawing.Color.White;
            this.songtitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.songtitle.Location = new System.Drawing.Point(16, 9);
            this.songtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.songtitle.Name = "songtitle";
            this.songtitle.Size = new System.Drawing.Size(611, 32);
            this.songtitle.TabIndex = 4;
            this.songtitle.Text = "song";
            this.songtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.songtitle.DoubleClick += new System.EventHandler(this.songtitle_DoubleClick);
            // 
            // songPos
            // 
            this.songPos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.songPos.BackColor = System.Drawing.Color.Transparent;
            this.songPos.Font = new System.Drawing.Font("Open Sans", 27.75F);
            this.songPos.ForeColor = System.Drawing.Color.White;
            this.songPos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.songPos.Location = new System.Drawing.Point(20, 353);
            this.songPos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.songPos.Name = "songPos";
            this.songPos.Size = new System.Drawing.Size(607, 67);
            this.songPos.TabIndex = 11;
            this.songPos.Text = "--:-- / --:--";
            this.songPos.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // visualizationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.songPos);
            this.Controls.Add(this.videoPanel);
            this.Controls.Add(this.songAlbum);
            this.Controls.Add(this.songArtist);
            this.Controls.Add(this.songtitle);
            this.Controls.Add(this.albumBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "visualizationUI";
            this.Text = "visualizationUI";
            this.Load += new System.EventHandler(this.visualizationUI_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.visualizationUI_Paint);
            this.DoubleClick += new System.EventHandler(this.visualizationUI_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.albumBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Label2 songtitle;
        public Label2 songAlbum;
        public Label2 songArtist;
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.Panel videoPanel;
        private System.Windows.Forms.PictureBox albumBox;
        public Label2 songPos;
    }
}