using System;
namespace Drastic.DownloadButton.Sample
{
    public class PKDownloadPictureViewController : UIViewController, IPKDownloadButtonDelegate, IPKDownloaderSimulatorDelegate
    {
        public PKDownloadButton DownloadButton { get; set; } = new PKDownloadButton();
        public UIImageView ImageView { get; set; } = new UIImageView();
        private PKDownloaderSimulator downloaderSimulator;
        private PKDownloaderSimulator pendingSimulator;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            ImageView.Hidden = true;
            downloaderSimulator = new PKDownloaderSimulator(0.1);
            downloaderSimulator.Delegate = this;
            pendingSimulator = new PKDownloaderSimulator(0.05);
            pendingSimulator.Delegate = this;
        }

        public void SimulatorDidUpdateProgress(PKDownloaderSimulator simulator, double progress)
        {
            if (simulator == pendingSimulator)
            {
                if (progress == 1)
                {
                    DownloadButton.State = PKDownloadButtonState.Downloading;
                    downloaderSimulator.StartDownload();
                }
            }
            else if (simulator == downloaderSimulator)
            {
                DownloadButton.StopDownloadButton.Progress = (float)progress;
                if (progress == 1)
                {
                    DownloadButton.State = PKDownloadButtonState.Downloaded;
                    ImageView.Hidden = false;
                }
            }
        }

        public void CurrentState(PKDownloadButton downloadButton, PKDownloadButtonState state)
        {
            switch (state)
            {
                case PKDownloadButtonState.StartDownload:
                    DownloadButton.State = PKDownloadButtonState.Pending;
                    pendingSimulator.StartDownload();
                    break;
                case PKDownloadButtonState.Pending:
                    pendingSimulator.CancelDownload();
                    DownloadButton.State = PKDownloadButtonState.StartDownload;
                    break;
                case PKDownloadButtonState.Downloading:
                    downloaderSimulator.CancelDownload();
                    DownloadButton.State = PKDownloadButtonState.StartDownload;
                    break;
                case PKDownloadButtonState.Downloaded:
                    DownloadButton.State = PKDownloadButtonState.StartDownload;
                    ImageView.Hidden = true;
                    break;
                default:
                    throw new NotSupportedException("Unsupported state");
            }
        }
    }
}