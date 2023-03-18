using Drastic.DownloadButton.Sample;

namespace Drastic.DownloadButton.tvOS;

[Register("AppDelegate")]
public class AppDelegate : UIApplicationDelegate
{
    public override UIWindow? Window
    {
        get;
        set;
    }

    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
        this.Window = new UIWindow();

        var dv = new PKViewController();

        this.Window!.RootViewController = new UIKit.UINavigationController(dv);
        this.Window!.MakeKeyAndVisible();
        return true;
    }
}
