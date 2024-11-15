using System.Diagnostics;

namespace DownloadVideoApp
{
    public partial class DownloadCutsYoutubeApp : Form
    {
        public DownloadCutsYoutubeApp()
        {
            InitializeComponent(); 
            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
        }

        private async void DownloadButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UrlYoutubeTextBox.Text))
            {
                errorProvider.SetError(UrlYoutubeTextBox, "Por favor, insira uma URL do YouTube.");
                return; 
            }
            else
            {
                errorProvider.SetError(UrlYoutubeTextBox, string.Empty);
            }

            DownloadProgressBar.Value = 25;
            UpdateStatusLabel("Fazendo download...");

            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string videoPath = Path.Combine(basePath, "videos");
            Directory.CreateDirectory(videoPath); 

            string videoFilePath = Path.Combine(videoPath, "video.mp4"); 
            DownloadProgressBar.Value = 35;

            string videoUrl = UrlYoutubeTextBox.Text; 
            await DownloadVideoWithYtDlpAsync(videoUrl, videoFilePath);

            UpdateStatusLabel("Download concluído!");
            DownloadProgressBar.Value = 100;
        }

        private void UpdateStatusLabel(string status)
        {
            if (statusLabel.InvokeRequired)
            {
                statusLabel.Invoke(new Action(() => {
                    statusLabel.Text = $"Status: {status}";
                    statusLabel.Refresh(); 
                }));
            }
            else
            {
                statusLabel.Text = $"Status: {status}";
                statusLabel.Refresh();
            }
        }

        public async Task DownloadVideoWithYtDlpAsync(string videoUrl, string outputFilePath)
        {
            var process = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = "yt-dlp",
                    Arguments = $"-f best -o \"{outputFilePath}\" \"{videoUrl}\"",
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            process.Start();
            await process.WaitForExitAsync(); 
        }
    }
}
