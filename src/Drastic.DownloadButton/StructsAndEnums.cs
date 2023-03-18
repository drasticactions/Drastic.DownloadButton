using ObjCRuntime;

namespace Drastic.DownloadButton
{
	[Native]
	public enum PKDownloadButtonState : ulong
	{
		StartDownload,
		Pending,
		Downloading,
		Downloaded
	}
}
