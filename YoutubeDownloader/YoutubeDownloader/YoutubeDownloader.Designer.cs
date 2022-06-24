namespace YoutubeDownloader
{
    partial class YoutubeDownloader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoutubeDownloader));
            this.YTlink_Txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.GitHubLink = new System.Windows.Forms.Label();
            this.dirBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.downloadBtn = new Guna.UI2.WinForms.Guna2Button();
            this.ShowbtnTimer = new System.Windows.Forms.Timer(this.components);
            this.CloseBtn = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.Thumbnail = new Guna.UI2.WinForms.Guna2PictureBox();
            this.YTLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.DownloadprogBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YTLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // YTlink_Txt
            // 
            this.YTlink_Txt.Animated = true;
            this.YTlink_Txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.YTlink_Txt.BorderRadius = 9;
            this.YTlink_Txt.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.YTlink_Txt.BorderThickness = 3;
            this.YTlink_Txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.YTlink_Txt.DefaultText = "";
            this.YTlink_Txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.YTlink_Txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.YTlink_Txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.YTlink_Txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.YTlink_Txt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.YTlink_Txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.YTlink_Txt.Font = new System.Drawing.Font("Poppins", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YTlink_Txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.YTlink_Txt.Location = new System.Drawing.Point(218, 27);
            this.YTlink_Txt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.YTlink_Txt.Name = "YTlink_Txt";
            this.YTlink_Txt.PasswordChar = '\0';
            this.YTlink_Txt.PlaceholderText = "youtube video link 🔍";
            this.YTlink_Txt.SelectedText = "";
            this.YTlink_Txt.Size = new System.Drawing.Size(855, 48);
            this.YTlink_Txt.TabIndex = 0;
            this.YTlink_Txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GitHubLink
            // 
            this.GitHubLink.AutoSize = true;
            this.GitHubLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GitHubLink.Font = new System.Drawing.Font("MagdaCleanMono", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GitHubLink.ForeColor = System.Drawing.Color.Snow;
            this.GitHubLink.Location = new System.Drawing.Point(8, 842);
            this.GitHubLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.GitHubLink.Name = "GitHubLink";
            this.GitHubLink.Size = new System.Drawing.Size(295, 15);
            this.GitHubLink.TabIndex = 1;
            this.GitHubLink.Text = "SauToriN.xyz | github.com/h3li0p4us3";
            this.GitHubLink.Click += new System.EventHandler(this.GitHubLink_Click);
            // 
            // downloadBtn
            // 
            this.downloadBtn.Animated = true;
            this.downloadBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.downloadBtn.BorderRadius = 9;
            this.downloadBtn.BorderThickness = 3;
            this.downloadBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.downloadBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.downloadBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.downloadBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.downloadBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.downloadBtn.Font = new System.Drawing.Font("Museo Sans Cyrl 900", 9F, System.Drawing.FontStyle.Bold);
            this.downloadBtn.ForeColor = System.Drawing.Color.White;
            this.downloadBtn.Location = new System.Drawing.Point(536, 758);
            this.downloadBtn.Name = "downloadBtn";
            this.downloadBtn.Size = new System.Drawing.Size(215, 45);
            this.downloadBtn.TabIndex = 3;
            this.downloadBtn.Text = "Download";
            this.downloadBtn.Click += new System.EventHandler(this.downloadBtn_ClickAsync);
            // 
            // ShowbtnTimer
            // 
            this.ShowbtnTimer.Enabled = true;
            this.ShowbtnTimer.Tick += new System.EventHandler(this.ShowbtnTimer_Tick);
            // 
            // CloseBtn
            // 
            this.CloseBtn.Image = global::YoutubeDownloader.Properties.Resources.closePicture;
            this.CloseBtn.ImageRotate = 0F;
            this.CloseBtn.Location = new System.Drawing.Point(1212, 5);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CloseBtn.Size = new System.Drawing.Size(35, 33);
            this.CloseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CloseBtn.TabIndex = 4;
            this.CloseBtn.TabStop = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // Thumbnail
            // 
            this.Thumbnail.BorderRadius = 6;
            this.Thumbnail.FillColor = System.Drawing.Color.Transparent;
            this.Thumbnail.Image = global::YoutubeDownloader.Properties.Resources.unknown_Thumbnail;
            this.Thumbnail.ImageRotate = 0F;
            this.Thumbnail.Location = new System.Drawing.Point(241, 153);
            this.Thumbnail.Margin = new System.Windows.Forms.Padding(2);
            this.Thumbnail.Name = "Thumbnail";
            this.Thumbnail.Size = new System.Drawing.Size(870, 566);
            this.Thumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Thumbnail.TabIndex = 2;
            this.Thumbnail.TabStop = false;
            // 
            // YTLogo
            // 
            this.YTLogo.Image = global::YoutubeDownloader.Properties.Resources.youtube_logo;
            this.YTLogo.ImageRotate = 0F;
            this.YTLogo.Location = new System.Drawing.Point(20, 32);
            this.YTLogo.Margin = new System.Windows.Forms.Padding(2);
            this.YTLogo.Name = "YTLogo";
            this.YTLogo.Size = new System.Drawing.Size(120, 36);
            this.YTLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.YTLogo.TabIndex = 0;
            this.YTLogo.TabStop = false;
            this.YTLogo.Click += new System.EventHandler(this.YTLogo_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Gill Sans MT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Cornsilk;
            this.titleLabel.Location = new System.Drawing.Point(247, 162);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(73, 18);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "Undefined";
            // 
            // DownloadprogBar
            // 
            this.DownloadprogBar.Animated = true;
            this.DownloadprogBar.BackColor = System.Drawing.Color.Transparent;
            this.DownloadprogBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(213)))), ((int)(((byte)(218)))), ((int)(((byte)(223)))));
            this.DownloadprogBar.FillThickness = 3;
            this.DownloadprogBar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.DownloadprogBar.ForeColor = System.Drawing.Color.White;
            this.DownloadprogBar.Location = new System.Drawing.Point(767, 763);
            this.DownloadprogBar.Minimum = 0;
            this.DownloadprogBar.Name = "DownloadprogBar";
            this.DownloadprogBar.ProgressThickness = 3;
            this.DownloadprogBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.DownloadprogBar.Size = new System.Drawing.Size(36, 36);
            this.DownloadprogBar.TabIndex = 6;
            this.DownloadprogBar.Text = "guna2CircleProgressBar1";
            this.DownloadprogBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.DownloadprogBar.UseTransparentBackground = true;
            this.DownloadprogBar.Value = 40;
            this.DownloadprogBar.Visible = false;
            // 
            // YoutubeDownloader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(1254, 868);
            this.Controls.Add(this.DownloadprogBar);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.CloseBtn);
            this.Controls.Add(this.downloadBtn);
            this.Controls.Add(this.Thumbnail);
            this.Controls.Add(this.GitHubLink);
            this.Controls.Add(this.YTlink_Txt);
            this.Controls.Add(this.YTLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "YoutubeDownloader";
            this.Text = "Youtube Downloader - SauToriN.xyz";
            this.Load += new System.EventHandler(this.YoutubeDownloader_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.YoutubeDownloader_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.YoutubeDownloader_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.YoutubeDownloader_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.CloseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YTLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox YTLogo;
        private Guna.UI2.WinForms.Guna2TextBox YTlink_Txt;
        private System.Windows.Forms.Label GitHubLink;
        private Guna.UI2.WinForms.Guna2PictureBox Thumbnail;
        private System.Windows.Forms.FolderBrowserDialog dirBrowserDialog;
        private Guna.UI2.WinForms.Guna2Button downloadBtn;
        private System.Windows.Forms.Timer ShowbtnTimer;
        private Guna.UI2.WinForms.Guna2CirclePictureBox CloseBtn;
        private System.Windows.Forms.Label titleLabel;
        private Guna.UI2.WinForms.Guna2CircleProgressBar DownloadprogBar;
    }
}

