namespace DownloadVideoApp
{
    partial class DownloadCutsYoutubeApp
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
            components = new System.ComponentModel.Container();
            UrlYoutubeTextBox = new TextBox();
            UrlYoutubelabel = new Label();
            DownloadButton = new Button();
            DownloadProgressBar = new ProgressBar();
            groupBoxDownloadVideo = new GroupBox();
            statusLabel = new Label();
            errorProvider = new ErrorProvider(components);
            groupBoxDownloadVideo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // UrlYoutubeTextBox
            // 
            UrlYoutubeTextBox.Location = new Point(6, 39);
            UrlYoutubeTextBox.Name = "UrlYoutubeTextBox";
            UrlYoutubeTextBox.Size = new Size(587, 23);
            UrlYoutubeTextBox.TabIndex = 0;
            // 
            // UrlYoutubelabel
            // 
            UrlYoutubelabel.AutoSize = true;
            UrlYoutubelabel.Location = new Point(6, 21);
            UrlYoutubelabel.Name = "UrlYoutubelabel";
            UrlYoutubelabel.Size = new Size(75, 15);
            UrlYoutubelabel.TabIndex = 1;
            UrlYoutubelabel.Text = "URL Youtube";
            // 
            // DownloadButton
            // 
            DownloadButton.Location = new Point(628, 39);
            DownloadButton.Name = "DownloadButton";
            DownloadButton.Size = new Size(163, 23);
            DownloadButton.TabIndex = 2;
            DownloadButton.Text = "Download and process";
            DownloadButton.UseVisualStyleBackColor = true;
            DownloadButton.Click += DownloadButton_Click;
            // 
            // DownloadProgressBar
            // 
            DownloadProgressBar.Location = new Point(6, 68);
            DownloadProgressBar.Name = "DownloadProgressBar";
            DownloadProgressBar.Size = new Size(785, 23);
            DownloadProgressBar.TabIndex = 3;
            // 
            // groupBoxDownloadVideo
            // 
            groupBoxDownloadVideo.Controls.Add(statusLabel);
            groupBoxDownloadVideo.Controls.Add(UrlYoutubeTextBox);
            groupBoxDownloadVideo.Controls.Add(UrlYoutubelabel);
            groupBoxDownloadVideo.Controls.Add(DownloadProgressBar);
            groupBoxDownloadVideo.Controls.Add(DownloadButton);
            groupBoxDownloadVideo.Location = new Point(12, 12);
            groupBoxDownloadVideo.Name = "groupBoxDownloadVideo";
            groupBoxDownloadVideo.Size = new Size(839, 105);
            groupBoxDownloadVideo.TabIndex = 5;
            groupBoxDownloadVideo.TabStop = false;
            groupBoxDownloadVideo.Text = "Download video";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new Point(628, 19);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(39, 15);
            statusLabel.TabIndex = 4;
            statusLabel.Text = "Status";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // DownloadCutsYoutubeApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(863, 124);
            Controls.Add(groupBoxDownloadVideo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "DownloadCutsYoutubeApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "YTD. Media Converter";
            groupBoxDownloadVideo.ResumeLayout(false);
            groupBoxDownloadVideo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox UrlYoutubeTextBox;
        private Label UrlYoutubelabel;
        private Button DownloadButton;
        private ProgressBar DownloadProgressBar;
        private GroupBox groupBoxDownloadVideo;
        private Label statusLabel;
        private ErrorProvider errorProvider;
    }
}
