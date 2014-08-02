using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace visualizationPlugin
{
    public partial class visualizationUI : Form
    {
        public visualizationUI()
        {
            InitializeComponent();
            this.Controls.Remove(songtitle);
            this.Controls.Remove(songAlbum);
            this.Controls.Remove(songArtist);
            albumBox.Controls.Add(songtitle);
            albumBox.Controls.Add(songAlbum);
            albumBox.Controls.Add(songArtist); // for transparency to work
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.F12:
                    gtype++;
                    if (gtype == 7) gtype = 0;
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        int gtype = (int)libZPlay.TFFTGraphType.gtAreaLeftOnTop;
        
        private void updateTimer_Tick(object sender, EventArgs e)
        {
            fPlayer_2.Player p=(fPlayer_2.Player)this.Tag;
            if (p!=null)
            {
                
                if (this.songtitle.Text!=p.songname.Text) this.songtitle.Text = p.songname.Text;
                if (this.songArtist.Text!=p.songinfo.Text.Split('/')[0]) this.songArtist.Text = p.songinfo.Text.Split('/')[0];
                if (p.songinfo.Text.Split('/').Length > 1 && this.songAlbum.Text!=p.songinfo.Text.Split('/')[1])
                {
                    this.songAlbum.Text = p.songinfo.Text.Split('/')[1];
                }
                if (this.albumBox.Image==null || p.songalbum.Image==null || (!this.albumBox.Image.Equals(p.songalbum.Image) && !p.songalbum.Image.Equals(p.songalbum.ErrorImage)))// fPlayer default cover should not appear
                {
                    
                    
                    if (Height > Width)
                    {
                        this.albumBox.Height = Height;
                        this.albumBox.Width = Height;
                        this.albumBox.Top = 0;
                        this.albumBox.Left = -(this.Height - this.Width)/2;
                        songtitle.Left = -this.albumBox.Left+16;
                        songAlbum.Left = -this.albumBox.Left+16;
                        songArtist.Left = -this.albumBox.Left+16;
                        songtitle.Top = 9;
                        songArtist.Top = Height-220;
                        songAlbum.Top = Height - 188;
                    }
                    else if (Height==Width)
                    {
                        this.albumBox.Height = Height;
                        this.albumBox.Width = Width;
                        this.albumBox.Top = 0;
                        this.albumBox.Left = 0;
                        songtitle.Top = 9;
                        songAlbum.Top = Height - 60;
                        songArtist.Top = Height - 28;
                        songtitle.Left = 16;
                        songArtist.Left = 16;
                        songAlbum.Left = 16;
                    } else {
                        this.albumBox.Height = Width;
                        this.albumBox.Width = Width;
                        this.albumBox.Top = -(this.Width - this.Height) / 2;
                        songtitle.Left = 16;
                        songAlbum.Left = 16;
                        songArtist.Left = 16;
                        songtitle.Top = -this.albumBox.Top+9;
                        songArtist.Top = -this.albumBox.Top+(this.Height - 60);
                        songAlbum.Top = -this.albumBox.Top+(this.Height - 28);
                    }
                    songtitle.ForeColor = bestColor((Bitmap)p.songalbum.Image,songtitle);
                    songArtist.ForeColor = bestColor((Bitmap)p.songalbum.Image, songArtist);
                    songAlbum.ForeColor = bestColor((Bitmap)p.songalbum.Image, songAlbum);
                    this.albumBox.Image = p.songalbum.Image;
                    this.Update();
                    this.albumBox.Update();
                    this.Refresh();
                    this.songtitle.BackColor = Color.Transparent;
                    this.songArtist.BackColor = Color.Transparent;
                    this.songAlbum.BackColor = Color.Transparent;
                    this.Update();
                }
                libZPlay.ZPlay audioplayer = (libZPlay.ZPlay)p.gI().impl_command("GETZPLAY",null)[0];
                if (audioplayer != null && gtype!=6)
                {
                    if (refreshed) videoPanel.Visible = true;
                    refreshed = false;
                    audioplayer.SetFFTGraphParam(libZPlay.TFFTGraphParamID.gpGraphType, gtype);
                    audioplayer.SetFFTGraphParam(libZPlay.TFFTGraphParamID.gpFFTPoints, 32);
                    audioplayer.SetFFTGraphParam(libZPlay.TFFTGraphParamID.gpHorizontalScale, (int) libZPlay.TFFTGraphHorizontalScale.gsLinear);
                    audioplayer.SetFFTGraphParam(libZPlay.TFFTGraphParamID.gpSubgrid, 0);
                    audioplayer.SetFFTGraphParam(libZPlay.TFFTGraphParamID.gpTransparency, 30);
                    audioplayer.SetFFTGraphParam(libZPlay.TFFTGraphParamID.gpDecibelGridVisible, 0);
                    audioplayer.SetFFTGraphParam(libZPlay.TFFTGraphParamID.gpDecibelScaleVisible, 0);
                    audioplayer.SetFFTGraphParam(libZPlay.TFFTGraphParamID.gpFrequencyScaleVisible, 0);
                    audioplayer.SetFFTGraphParam(libZPlay.TFFTGraphParamID.gpFrequencyGridVisible, 0);
                    audioplayer.SetFFTGraphParam(libZPlay.TFFTGraphParamID.gpWindow, (int)libZPlay.TFFTWindow.fwHamming);
                    audioplayer.SetFFTGraphParam(libZPlay.TFFTGraphParamID.gpTransparency, 30);
                    audioplayer.DrawFFTGraphOnHWND(videoPanel.Handle, 0,0,videoPanel.Width,videoPanel.Height);
                }
                else if(!refreshed)
                {
                    videoPanel.Visible = false;
                    videoPanel.Refresh();
                    videoPanel.Update();
                    this.albumBox.Update();
                    this.songtitle.BackColor = Color.Transparent;
                    this.songArtist.BackColor = Color.Transparent;
                    this.songAlbum.BackColor = Color.Transparent;
                    refreshed = true;
                }
            }
        }

        public Color bestColor(Bitmap image,Control client)
        {
            // This algorithm calculates which is the color that makes more contrast with the given image.
            int SKIP = 10; // Will skip SKIP pixels for each row and column when taking tests to do faster calculations.
            int r = 0; int g = 0; int b = 0; int n = 0;
            for (int i = 0; i < image.Size.Width; i=i+SKIP)
            {
                for (int j = 0; j < image.Size.Height; j = j + SKIP)
                {
                    r = r + image.GetPixel(i, j).R;
                    g = g + image.GetPixel(i, j).G;
                    b = b + image.GetPixel(i, j).B;
                    n++;
                }
            }
            // Calculate mean of each color component
            r = r / n;
            g = g / n;
            b = b / n;
            // That is the mean color of the image. Invert it.
            r = 255 - r;
            g = 255 - g;
            b = 255 - b;
            // Up to here, we may have finished. However, worst-cases tests prove that despite this color combinations are generally more visible, some images may make it still difficult to see the color.
            // Pure colors have more chances to be seen by human eye as they are completely bright or dark.
            // Now aproximate the color as we only want pure tones
            int[] vals = { 0, 255 };
            r = shortest(r, vals);
            g = shortest(g, vals);
            b = shortest(b, vals);
            return Color.FromArgb(r, g, b);
        }
        /**
         * Returns the value in vals that is closer to a.
         * \param a The target
         * \param vals The approximation values.
         */
        public int shortest(int a, int[] vals)
        {
            int shortest = vals[0];
            foreach (int b in vals)
            {
                if (Math.Abs(b - a) < Math.Abs(shortest - a)) shortest = b;
            }
            return shortest;
        }
        bool refreshed = false;
        private void visualizationUI_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void songtitle_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void songArtist_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void songAlbum_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void songPos_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void visualizationUI_Load(object sender, EventArgs e)
        {
            updateTimer_Tick(sender, e);
        }

        int waiter = 0;
        private void visualizationUI_Paint(object sender, PaintEventArgs e)
        {
            waiter++;
            if (waiter == 50)
            {
                fPlayer_2.Player p=(fPlayer_2.Player)this.Tag;
                if (p != null)
                {
                    libZPlay.ZPlay zp = (libZPlay.ZPlay)p.gI().impl_command("GETZPLAY", null)[0];
                    // set horizontal scale to logarithmic
                    zp.SetFFTGraphParam(libZPlay.TFFTGraphParamID.gpHorizontalScale,(int)libZPlay.TFFTGraphParamID.gpHorizontalScale);

                    // set FFT points to 256
                    zp.SetFFTGraphParam(libZPlay.TFFTGraphParamID.gpFFTPoints, 256);

                    // set graph type to bars, left channel on top
                    zp.SetFFTGraphParam(libZPlay.TFFTGraphParamID.gpGraphType, (int)libZPlay.TFFTGraphType.gtAreaLeftOnTop);
                    zp.DrawFFTGraphOnHWND(this.Handle, 0, 0, this.Width, this.Height);
                    
                }
            }
        }

        private void videoPanel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
