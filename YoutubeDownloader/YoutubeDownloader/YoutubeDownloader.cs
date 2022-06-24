
/*
SauToriN.xyz | Developed By h3li0p4us3 . github.com/SauToriN || github.com/h3li0p4us3
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using YoutubeExplode;
using System.Diagnostics;
using YoutubeExplode.Converter;
using System.IO;

namespace YoutubeDownloader
{
    public partial class YoutubeDownloader : Form
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        public YoutubeDownloader()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

        }


        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void YoutubeDownloader_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void YoutubeDownloader_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void YoutubeDownloader_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        

        private void YTLogo_Click(object sender, EventArgs e)
        {
            Process.Start("https://youtube.com");
        }

        private void GitHubLink_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/SauToriN");
            Process.Start("https://github.com/h3li0p4us3");
            MessageBox.Show("don't forgot to leave a STAR 😊");
        }

        private void YoutubeDownloader_Load(object sender, EventArgs e)
        {
            ShowbtnTimer.Start();
        }

        private async void downloadBtn_ClickAsync(object sender, EventArgs e)
        {
            
            DialogResult Result = dirBrowserDialog.ShowDialog();
            if (YTlink_Txt.Text == "")
            {
                MessageBox.Show("Youtube Link can not be empty");

            }
            // Check YTlink Textbox is a url or not
            else if (!YTlink_Txt.Text.StartsWith("http") || !YTlink_Txt.Text.StartsWith("https"))
            {
                MessageBox.Show("only URL can be use");
            }

            var youtube = new YoutubeClient();
            var video = await youtube.Videos.GetAsync(YTlink_Txt.Text);
            titleLabel.Text = video.Title;
            
            if (Result == DialogResult.OK)
            {

                string VideoID = YTlink_Txt.Text.Replace(@"https://www.youtube.com/watch?v=","");
                // Download Thumbnails
                Thumbnail.ImageLocation = $"http://img.youtube.com/vi/{VideoID}/0.jpg";
                // Get Title of Video
                string SavedName = video.Title.ToString();
                // ask user to select a Folder to save video
                var directoryToSave = dirBrowserDialog.SelectedPath.ToString();

                
                downloadBtn.Enabled = false;
                DownloadprogBar.Visible = true;
                // Download & Save Video to directory
                await youtube.Videos.DownloadAsync(YTlink_Txt.Text, directoryToSave + $"\\{SavedName}.mp4");
                DownloadprogBar.Visible = false;
                downloadBtn.Enabled = true;
                MessageBox.Show("Download Finished .");
            }
            else
            {
                MessageBox.Show("Download Canceled");
            }

        }

        private void ShowbtnTimer_Tick(object sender, EventArgs e)
        {
            // Check if user put the link or not
            if(YTlink_Txt.Text == "")
            {
                downloadBtn.Enabled = false;
                downloadBtn.Visible = false;
            }
            else
            {
                downloadBtn.Enabled = true;
                downloadBtn.Visible = true;
            }
        }

        

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
