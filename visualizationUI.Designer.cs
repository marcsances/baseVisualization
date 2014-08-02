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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(visualizationUI));
            this.songtitle = new Label2();
            this.songPos = new Label2();
            this.songAlbum = new Label2();
            this.songArtist = new Label2();
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // songtitle
            // 
            this.songtitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.songtitle.BackColor = System.Drawing.Color.Transparent;
            this.songtitle.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold);
            this.songtitle.ForeColor = System.Drawing.Color.White;
            this.songtitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.songtitle.Location = new System.Drawing.Point(13, 9);
            this.songtitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.songtitle.Name = "songtitle";
            this.songtitle.Size = new System.Drawing.Size(614, 32);
            this.songtitle.TabIndex = 4;
            this.songtitle.Text = "song";
            this.songtitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // songPos
            // 
            this.songPos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.songPos.BackColor = System.Drawing.Color.Transparent;
            this.songPos.Font = new System.Drawing.Font("Open Sans", 27.75F);
            this.songPos.ForeColor = System.Drawing.Color.White;
            this.songPos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.songPos.Location = new System.Drawing.Point(13, 366);
            this.songPos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.songPos.Name = "songPos";
            this.songPos.Size = new System.Drawing.Size(614, 54);
            this.songPos.TabIndex = 8;
            this.songPos.Text = "--:--";
            this.songPos.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // songAlbum
            // 
            this.songAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.songAlbum.BackColor = System.Drawing.Color.Transparent;
            this.songAlbum.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.songAlbum.ForeColor = System.Drawing.Color.White;
            this.songAlbum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.songAlbum.Location = new System.Drawing.Point(13, 452);
            this.songAlbum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.songAlbum.Name = "songAlbum";
            this.songAlbum.Size = new System.Drawing.Size(614, 19);
            this.songAlbum.TabIndex = 7;
            this.songAlbum.Text = "Album";
            this.songAlbum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // songArtist
            // 
            this.songArtist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.songArtist.BackColor = System.Drawing.Color.Transparent;
            this.songArtist.Font = new System.Drawing.Font("Open Sans", 12F);
            this.songArtist.ForeColor = System.Drawing.Color.White;
            this.songArtist.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.songArtist.Location = new System.Drawing.Point(13, 420);
            this.songArtist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.songArtist.Name = "songArtist";
            this.songArtist.Size = new System.Drawing.Size(614, 32);
            this.songArtist.TabIndex = 6;
            this.songArtist.Text = "Artist";
            this.songArtist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 50;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox.ErrorImage")));
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox.Location = new System.Drawing.Point(245, 165);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(150, 150);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 9;
            this.pictureBox.TabStop = false;
            // 
            // visualizationUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.songPos);
            this.Controls.Add(this.songAlbum);
            this.Controls.Add(this.songArtist);
            this.Controls.Add(this.songtitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "visualizationUI";
            this.Text = "visualizationUI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public Label2 songtitle;
        public Label2 songPos;
        public Label2 songAlbum;
        public Label2 songArtist;
        private System.Windows.Forms.Timer updateTimer;
        public System.Windows.Forms.PictureBox pictureBox;
    }
}