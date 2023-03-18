using System;
namespace Drastic.DownloadButton.Sample
{
    public class PKViewController : UIViewController
    {
        private PKPendingView viewPKPendingView1 = new PKPendingView();
        private PKStopDownloadButton viewPKStopDownloadButton1 = new PKStopDownloadButton();
        private PKCircleProgressView viewPKCircleProgressView1 = new PKCircleProgressView();
        private PKCircleView viewPKCircleView1 = new PKCircleView();
        private UIView view1 = new UIView();
        private PKPendingView viewPKPendingView2 = new PKPendingView();
        private PKStopDownloadButton viewPKStopDownloadButton2 = new PKStopDownloadButton();
        private PKCircleProgressView viewPKCircleProgressView2 = new PKCircleProgressView();
        private PKCircleView viewPKCircleView2 = new PKCircleView();
        private UIView view2 = new UIView();

        public PKViewController() : base()
        {
            base.Title = "components";
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            SetupUI();
            SetupLayout();
        }

        private void SetupUI()
        {
            // this.View.BackgroundColor = UIColor.White;

            view1.AddSubviews(viewPKPendingView1, viewPKStopDownloadButton1, viewPKCircleProgressView1, viewPKCircleView1);
            this.View.AddSubviews(view1, view2);

            // view1.BackgroundColor = UIColor.White;
            view1.TintColor = UIColor.FromRGB(47, 165, 255);
            view1.TranslatesAutoresizingMaskIntoConstraints = false;

            //viewPKCircleView1.BackgroundColor = UIColor.White;
            viewPKCircleView1.TranslatesAutoresizingMaskIntoConstraints = false;
            viewPKCircleView1.SetValueForKey(new NSNumber(2), new NSString("lineWidth"));
            viewPKCircleView1.SetValueForKey(new NSNumber(3), new NSString("startAngleRadians"));
            viewPKCircleView1.SetValueForKey(new NSNumber(8), new NSString("endAngleRadians"));

            //viewPKCircleProgressView1.BackgroundColor = UIColor.White;
            viewPKCircleProgressView1.TintColor = UIColor.FromRGB(76, 233, 73);
            viewPKCircleProgressView1.TranslatesAutoresizingMaskIntoConstraints = false;
            viewPKCircleProgressView1.SetValueForKey(new NSNumber(0.9), new NSString("progress"));
            viewPKCircleProgressView1.SetValueForKey(new NSNumber(1), new NSString("emptyLineWidth"));
            viewPKCircleProgressView1.SetValueForKey(new NSNumber(16), new NSString("radius"));
            viewPKCircleProgressView1.SetValueForKey(new NSNumber(7), new NSString("filledLineWidth"));

            //viewPKStopDownloadButton1.BackgroundColor = UIColor.White;
            viewPKStopDownloadButton1.TintColor = UIColor.FromRGB(4, 217, 50);
            viewPKStopDownloadButton1.TranslatesAutoresizingMaskIntoConstraints = false;
            viewPKStopDownloadButton1.SetValueForKey(new NSNumber(0.2), new NSString("progress"));
            viewPKStopDownloadButton1.SetValueForKey(new NSNumber(1), new NSString("emptyLineWidth"));
            viewPKStopDownloadButton1.SetValueForKey(new NSNumber(12), new NSString("stopButtonWidth"));
            viewPKStopDownloadButton1.SetValueForKey(new NSNumber(16), new NSString("radius"));
            viewPKStopDownloadButton1.SetValueForKey(new NSNumber(2), new NSString("filledLineWidth"));
            viewPKStopDownloadButton1.SetValueForKey(new NSNumber(false), new NSString("filledLineStyleOuter"));

            //viewPKPendingView1.BackgroundColor = UIColor.White;
            viewPKPendingView1.TranslatesAutoresizingMaskIntoConstraints = false;
            viewPKPendingView1.SetValueForKey(new NSNumber(0.5), new NSString("emptyLineRadians"));
            viewPKPendingView1.SetValueForKey(new NSNumber(0.5), new NSString("lineWidth"));
            viewPKPendingView1.SetValueForKey(new NSNumber(15), new NSString("radius"));

            //view2.BackgroundColor = UIColor.White;
            view2.TranslatesAutoresizingMaskIntoConstraints = false;

            view2.AddSubviews(viewPKPendingView2, viewPKStopDownloadButton2, viewPKCircleProgressView2, viewPKCircleView2);

            //viewPKCircleView2.BackgroundColor = UIColor.White;
            viewPKCircleView2.TintColor = UIColor.FromRGB(45, 219, 201);
            viewPKCircleView2.TranslatesAutoresizingMaskIntoConstraints = false;
            viewPKCircleView2.SetValueForKey(new NSNumber(-2), new NSString("startAngleRadians"));
            viewPKCircleView2.SetValueForKey(new NSNumber(2), new NSString("lineWidth"));
            viewPKCircleView2.SetValueForKey(new NSNumber(3), new NSString("endAngleRadians"));

            //viewPKCircleProgressView2.BackgroundColor = UIColor.White;
            viewPKCircleProgressView2.TintColor = UIColor.Black;
            viewPKCircleProgressView2.TranslatesAutoresizingMaskIntoConstraints = false;
            viewPKCircleProgressView2.SetValueForKey(new NSNumber(0.2), new NSString("progress"));
            viewPKCircleProgressView2.SetValueForKey(new NSNumber(17), new NSString("radius"));
            viewPKCircleProgressView2.SetValueForKey(new NSNumber(3), new NSString("emptyLineWidth"));
            viewPKCircleProgressView2.SetValueForKey(new NSNumber(5), new NSString("filledLineWidth"));
            viewPKCircleProgressView2.SetValueForKey(new NSNumber(false), new NSString("filledLineStyleOuter"));

            //viewPKStopDownloadButton2.BackgroundColor = UIColor.White;
            viewPKStopDownloadButton2.TintColor = UIColor.FromRGB(212, 41, 220);
            viewPKStopDownloadButton2.TranslatesAutoresizingMaskIntoConstraints = false;
            viewPKStopDownloadButton2.SetValueForKey(new NSNumber(0.2), new NSString("progress"));
            viewPKStopDownloadButton2.SetValueForKey(new NSNumber(12), new NSString("stopButtonWidth"));
            viewPKStopDownloadButton2.SetValueForKey(new NSNumber(21), new NSString("radius"));
            viewPKStopDownloadButton2.SetValueForKey(new NSNumber(3), new NSString("emptyLineWidth"));
            viewPKStopDownloadButton2.SetValueForKey(new NSNumber(6), new NSString("filledLineWidth"));
            viewPKStopDownloadButton2.SetValueForKey(new NSNumber(false), new NSString("filledLineStyleOuter"));

            //viewPKPendingView2.BackgroundColor = UIColor.White;
            viewPKPendingView2.TintColor = UIColor.FromRGB(255, 157, 0);
            viewPKPendingView2.TranslatesAutoresizingMaskIntoConstraints = false;
            viewPKPendingView2.SetValueForKey(new NSNumber(1.5), new NSString("emptyLineRadians"));
            viewPKPendingView2.SetValueForKey(new NSNumber(1.5), new NSString("lineWidth"));
            viewPKPendingView2.SetValueForKey(new NSNumber(15), new NSString("radius"));
        }

        private void SetupLayout()
        {
            view1.CenterXAnchor.ConstraintEqualTo(this.View.CenterXAnchor).Active = true;
            view2.TopAnchor.ConstraintEqualTo(view1.BottomAnchor, 28).Active = true;
            view1.TopAnchor.ConstraintEqualTo(TopLayoutGuide.BottomAnchor, 14).Active = true;
            view2.CenterXAnchor.ConstraintEqualTo(this.View.CenterXAnchor).Active = true;

            viewPKCircleProgressView2.LeadingAnchor.ConstraintEqualTo(view2.LeadingAnchor, 19).Active = true;
            viewPKCircleView2.LeadingAnchor.ConstraintEqualTo(viewPKStopDownloadButton2.TrailingAnchor, 25).Active = true;
            view2.CenterYAnchor.ConstraintEqualTo(viewPKCircleView2.CenterYAnchor).Active = true;
            view2.TrailingAnchor.ConstraintEqualTo(viewPKPendingView2.TrailingAnchor, 8).Active = true;
            view2.CenterYAnchor.ConstraintEqualTo(viewPKStopDownloadButton2.CenterYAnchor).Active = true;
            view2.HeightAnchor.ConstraintEqualTo(64).Active = true;
            view2.CenterYAnchor.ConstraintEqualTo(viewPKCircleProgressView2.CenterYAnchor).Active = true;
            view2.CenterYAnchor.ConstraintEqualTo(viewPKPendingView2.CenterYAnchor).Active = true;
            view2.WidthAnchor.ConstraintEqualTo(279).Active = true;
            viewPKStopDownloadButton2.LeadingAnchor.ConstraintEqualTo(viewPKCircleProgressView2.TrailingAnchor, 22).Active = true;
            viewPKPendingView2.LeadingAnchor.ConstraintEqualTo(viewPKCircleView2.TrailingAnchor, 21).Active = true;

            viewPKCircleView2.WidthAnchor.ConstraintEqualTo(42).Active = true;
            viewPKCircleView2.HeightAnchor.ConstraintEqualTo(47).Active = true;

            viewPKCircleProgressView2.HeightAnchor.ConstraintEqualTo(48).Active = true;
            viewPKCircleProgressView2.WidthAnchor.ConstraintEqualTo(45).Active = true;

            viewPKStopDownloadButton2.HeightAnchor.ConstraintEqualTo(58).Active = true;
            viewPKStopDownloadButton2.WidthAnchor.ConstraintEqualTo(49).Active = true;

            viewPKPendingView2.WidthAnchor.ConstraintEqualTo(48).Active = true;
            viewPKPendingView2.HeightAnchor.ConstraintEqualTo(50).Active = true;

            view1.CenterYAnchor.ConstraintEqualTo(viewPKPendingView1.CenterYAnchor).Active = true;
            view1.CenterYAnchor.ConstraintEqualTo(viewPKStopDownloadButton1.CenterYAnchor).Active = true;
            view1.WidthAnchor.ConstraintEqualTo(279).Active = true;
            viewPKPendingView1.LeadingAnchor.ConstraintEqualTo(viewPKCircleView1.TrailingAnchor, 21).Active = true;
            viewPKCircleProgressView1.LeadingAnchor.ConstraintEqualTo(view1.LeadingAnchor, 19).Active = true;
            viewPKCircleView1.LeadingAnchor.ConstraintEqualTo(viewPKStopDownloadButton1.TrailingAnchor, 25).Active = true;
            view1.HeightAnchor.ConstraintEqualTo(64).Active = true;
            view1.CenterYAnchor.ConstraintEqualTo(viewPKCircleProgressView1.CenterYAnchor).Active = true;
            view1.CenterYAnchor.ConstraintEqualTo(viewPKCircleView1.CenterYAnchor).Active = true;
            view1.TrailingAnchor.ConstraintEqualTo(viewPKPendingView1.TrailingAnchor, 8).Active = true;
            viewPKStopDownloadButton1.LeadingAnchor.ConstraintEqualTo(viewPKCircleProgressView1.TrailingAnchor, 22).Active = true;

            viewPKCircleView1.WidthAnchor.ConstraintEqualTo(42).Active = true;
            viewPKCircleView1.HeightAnchor.ConstraintEqualTo(47).Active = true;

            viewPKCircleProgressView1.WidthAnchor.ConstraintEqualTo(45).Active = true;
            viewPKCircleProgressView1.HeightAnchor.ConstraintEqualTo(48).Active = true;

            viewPKStopDownloadButton1.WidthAnchor.ConstraintEqualTo(49).Active = true;
            viewPKStopDownloadButton1.HeightAnchor.ConstraintEqualTo(58).Active = true;

            viewPKPendingView1.HeightAnchor.ConstraintEqualTo(50).Active = true;
            viewPKPendingView1.WidthAnchor.ConstraintEqualTo(48).Active = true;
        }
    }
}


