using System;

namespace Drastic.DownloadButton.Sample
{
    public class PKDownloaderSimulator
    {
        private static double progressStep = 0.01;
        private NSTimer timer;
        private double progress;
        private double progressInterval;

        public PKDownloaderSimulator(double progressInterval)
        {
            this.progressInterval = progressInterval;
        }

        public void StartDownload()
        {
            progress = 0;
            timer = NSTimer.CreateRepeatingScheduledTimer(TimeSpan.FromSeconds(progressInterval), IncreaseProgress);
        }

        public void CancelDownload()
        {
            progress = 0;
            timer?.Invalidate();
        }

        private void IncreaseProgress(NSTimer obj)
        {
            if (1.0 - progress > progressStep)
            {
                progress += progressStep;
            }
            else
            {
                progress = 1.0;
                timer?.Invalidate();
            }

            Delegate?.SimulatorDidUpdateProgress(this, progress);
        }

        public IPKDownloaderSimulatorDelegate Delegate { get; set; }
    }

    public interface IPKDownloaderSimulatorDelegate
    {
        void SimulatorDidUpdateProgress(PKDownloaderSimulator simulator, double progress);
    }
}