using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Drastic.DownloadButton
{
	// @interface PKDownloadButtonAnimations (CALayer)
	[Category]
	[BaseType (typeof(CALayer))]
	interface CALayer_PKDownloadButtonAnimations
	{
		// -(void)addRotationAnimationWithKey:(NSString *)animationKey fullRotationDuration:(NSTimeInterval)fullRotationDuration;
		[Export ("addRotationAnimationWithKey:fullRotationDuration:")]
		void AddRotationAnimationWithKey (string animationKey, double fullRotationDuration);

		// -(void)removeRotationAnimationWithKey:(NSString *)animationKey;
		[Export ("removeRotationAnimationWithKey:")]
		void RemoveRotationAnimationWithKey (string animationKey);

		// -(void)removeRotationAnimationWithKey:(NSString *)animationKey fullRotationDuration:(NSTimeInterval)fullRotationDuration;
		[Export ("removeRotationAnimationWithKey:fullRotationDuration:")]
		void RemoveRotationAnimationWithKey (string animationKey, double fullRotationDuration);
	}

	// @interface PKDownloadButton (NSLayoutConstraint)
	[Category]
	[BaseType (typeof(NSLayoutConstraint))]
	interface NSLayoutConstraint_PKDownloadButton
	{
		// +(NSArray *)constraintsForWrappedSubview:(UIView *)view withInsets:(UIEdgeInsets)insets;
		[Static]
		[Export ("constraintsForWrappedSubview:withInsets:")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] ConstraintsForWrappedSubview (UIView view, UIEdgeInsets insets);

		// +(NSArray *)horizontalConstraintsForWrappedSubview:(UIView *)view withInsets:(UIEdgeInsets)insets;
		[Static]
		[Export ("horizontalConstraintsForWrappedSubview:withInsets:")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] HorizontalConstraintsForWrappedSubview (UIView view, UIEdgeInsets insets);

		// +(NSArray *)verticalConstraintsForWrappedSubview:(UIView *)view withInsets:(UIEdgeInsets)insets;
		[Static]
		[Export ("verticalConstraintsForWrappedSubview:withInsets:")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] VerticalConstraintsForWrappedSubview (UIView view, UIEdgeInsets insets);

		// +(NSLayoutConstraint *)constraintForView:(UIView *)view withWidth:(CGFloat)width;
		[Static]
		[Export ("constraintForView:withWidth:")]
		NSLayoutConstraint ConstraintForView (UIView view, nfloat width);

		// +(NSLayoutConstraint *)constraintForView:(UIView *)view withHeight:(CGFloat)height;
		[Static]
		[Export ("constraintForView:withHeight:")]
		NSLayoutConstraint ConstraintForView (UIView view, nfloat height);

		// +(NSArray *)constraintsForView:(UIView *)view withSize:(CGSize)size;
		[Static]
		[Export ("constraintsForView:withSize:")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] ConstraintsForView (UIView view, CGSize size);

		// +(NSArray *)constraintsWithVisualFormat:(NSString *)format views:(NSDictionary *)views;
		[Static]
		[Export ("constraintsWithVisualFormat:views:")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] ConstraintsWithVisualFormat (string format, NSDictionary views);

		// +(NSLayoutConstraint *)constraintForCenterByYView:(UIView *)overlay withView:(UIView *)view;
		[Static]
		[Export ("constraintForCenterByYView:withView:")]
		NSLayoutConstraint ConstraintForCenterByYView (UIView overlay, UIView view);

		// +(NSLayoutConstraint *)constraintForCenterByXView:(UIView *)overlay withView:(UIView *)view;
		[Static]
		[Export ("constraintForCenterByXView:withView:")]
		NSLayoutConstraint ConstraintForCenterByXView (UIView overlay, UIView view);

		// +(NSArray *)constraintsForCenterView:(UIView *)overlay;
		[Static]
		[Export ("constraintsForCenterView:")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] ConstraintsForCenterView (UIView overlay);

		// +(NSArray *)constraintsForCenterView:(UIView *)overlay withView:(UIView *)view;
		[Static]
		[Export ("constraintsForCenterView:withView:")]
		[Verify (StronglyTypedNSArray)]
		NSObject[] ConstraintsForCenterView (UIView overlay, UIView view);
	}

	// @interface PKBorderedButton : UIButton
	[BaseType (typeof(UIButton))]
	interface PKBorderedButton
	{
		// @property (nonatomic) CGFloat cornerRadius;
		[Export ("cornerRadius")]
		nfloat CornerRadius { get; set; }

		// @property (nonatomic) CGFloat lineWidth;
		[Export ("lineWidth")]
		nfloat LineWidth { get; set; }

		// -(void)configureDefaultAppearance;
		[Export ("configureDefaultAppearance")]
		void ConfigureDefaultAppearance ();

		// -(void)cleanDefaultAppearance;
		[Export ("cleanDefaultAppearance")]
		void CleanDefaultAppearance ();
	}

	// @interface PKCircleProgressView : UIView
	[BaseType (typeof(UIView))]
	interface PKCircleProgressView
	{
		// @property (assign, nonatomic) CGFloat progress;
		[Export ("progress")]
		nfloat Progress { get; set; }

		// @property (assign, nonatomic) CGFloat filledLineWidth;
		[Export ("filledLineWidth")]
		nfloat FilledLineWidth { get; set; }

		// @property (assign, nonatomic) CGFloat emptyLineWidth;
		[Export ("emptyLineWidth")]
		nfloat EmptyLineWidth { get; set; }

		// @property (assign, nonatomic) CGFloat radius;
		[Export ("radius")]
		nfloat Radius { get; set; }

		// @property (assign, nonatomic) BOOL filledLineStyleOuter;
		[Export ("filledLineStyleOuter")]
		bool FilledLineStyleOuter { get; set; }
	}

	// @interface PKCircleView : UIView
	[BaseType (typeof(UIView))]
	interface PKCircleView
	{
		// @property (assign, nonatomic) CGFloat startAngleRadians;
		[Export ("startAngleRadians")]
		nfloat StartAngleRadians { get; set; }

		// @property (assign, nonatomic) CGFloat endAngleRadians;
		[Export ("endAngleRadians")]
		nfloat EndAngleRadians { get; set; }

		// @property (assign, nonatomic) CGFloat lineWidth;
		[Export ("lineWidth")]
		nfloat LineWidth { get; set; }
	}

	// @interface PKStopDownloadButton : PKCircleProgressView
	[BaseType (typeof(PKCircleProgressView))]
	interface PKStopDownloadButton
	{
		// @property (assign, nonatomic) CGFloat stopButtonWidth;
		[Export ("stopButtonWidth")]
		nfloat StopButtonWidth { get; set; }

		// @property (readonly, nonatomic, weak) UIButton * stopButton;
		[Export ("stopButton", ArgumentSemantic.Weak)]
		UIButton StopButton { get; }
	}

	// @interface PKPendingView : UIControl
	[BaseType (typeof(UIControl))]
	interface PKPendingView
	{
		// @property (readonly, nonatomic, weak) PKCircleView * circleView;
		[Export ("circleView", ArgumentSemantic.Weak)]
		PKCircleView CircleView { get; }

		// @property (assign, nonatomic) CGFloat radius;
		[Export ("radius")]
		nfloat Radius { get; set; }

		// @property (assign, nonatomic) CGFloat lineWidth;
		[Export ("lineWidth")]
		nfloat LineWidth { get; set; }

		// @property (assign, nonatomic) CGFloat emptyLineRadians;
		[Export ("emptyLineRadians")]
		nfloat EmptyLineRadians { get; set; }

		// @property (assign, nonatomic) CGFloat spinTime;
		[Export ("spinTime")]
		nfloat SpinTime { get; set; }

		// -(void)startSpin;
		[Export ("startSpin")]
		void StartSpin ();

		// -(void)stopSpin;
		[Export ("stopSpin")]
		void StopSpin ();
	}

	// typedef void (^DownloadButtonTappedCallback)(PKDownloadButton *, PKDownloadButtonState);
	delegate void DownloadButtonTappedCallback (PKDownloadButton arg0, PKDownloadButtonState arg1);

	// @protocol PKDownloadButtonDelegate <NSObject>
	[Protocol, Model (AutoGeneratedName = true)]
	[BaseType (typeof(NSObject))]
	interface PKDownloadButtonDelegate
	{
		// @required -(void)downloadButtonTapped:(PKDownloadButton *)downloadButton currentState:(PKDownloadButtonState)state;
		[Abstract]
		[Export ("downloadButtonTapped:currentState:")]
		void CurrentState (PKDownloadButton downloadButton, PKDownloadButtonState state);
	}

	// @interface PKDownloadButton : UIView
	[BaseType (typeof(UIView))]
	interface PKDownloadButton
	{
		[Wrap ("WeakDelegate")]
		PKDownloadButtonDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<PKDownloadButtonDelegate> delegate __attribute__((iboutlet));
		[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }

		// @property (copy, nonatomic) DownloadButtonTappedCallback callback;
		[Export ("callback", ArgumentSemantic.Copy)]
		DownloadButtonTappedCallback Callback { get; set; }

		// @property (readonly, nonatomic, weak) PKBorderedButton * startDownloadButton;
		[Export ("startDownloadButton", ArgumentSemantic.Weak)]
		PKBorderedButton StartDownloadButton { get; }

		// @property (readonly, nonatomic, weak) PKStopDownloadButton * stopDownloadButton;
		[Export ("stopDownloadButton", ArgumentSemantic.Weak)]
		PKStopDownloadButton StopDownloadButton { get; }

		// @property (readonly, nonatomic, weak) PKBorderedButton * downloadedButton;
		[Export ("downloadedButton", ArgumentSemantic.Weak)]
		PKBorderedButton DownloadedButton { get; }

		// @property (readonly, nonatomic, weak) PKPendingView * pendingView;
		[Export ("pendingView", ArgumentSemantic.Weak)]
		PKPendingView PendingView { get; }

		// @property (assign, nonatomic) PKDownloadButtonState state;
		[Export ("state", ArgumentSemantic.Assign)]
		PKDownloadButtonState State { get; set; }

		// -(void)updateStartDownloadButtonText:(NSString *)title;
		[Export ("updateStartDownloadButtonText:")]
		void UpdateStartDownloadButtonText (string title);

		// -(void)updateDownloadedButtonText:(NSString *)title;
		[Export ("updateDownloadedButtonText:")]
		void UpdateDownloadedButtonText (string title);

		// -(void)updateStartDownloadButtonText:(NSString *)title font:(UIFont *)font;
		[Export ("updateStartDownloadButtonText:font:")]
		void UpdateStartDownloadButtonText (string title, UIFont font);

		// -(void)updateDownloadedButtonText:(NSString *)title font:(UIFont *)font;
		[Export ("updateDownloadedButtonText:font:")]
		void UpdateDownloadedButtonText (string title, UIFont font);
	}

	// @interface PKDownloadButton (UIImage)
	[Category]
	[BaseType (typeof(UIImage))]
	interface UIImage_PKDownloadButton
	{
		// +(UIImage *)stopImageOfSize:(CGFloat)size color:(UIColor *)color;
		[Static]
		[Export ("stopImageOfSize:color:")]
		UIImage StopImageOfSize (nfloat size, UIColor color);

		// +(UIImage *)borderedImageWithFill:(UIColor *)fillColor radius:(CGFloat)radius lineColor:(UIColor *)lineColor lineWidth:(CGFloat)lineWidth;
		[Static]
		[Export ("borderedImageWithFill:radius:lineColor:lineWidth:")]
		UIImage BorderedImageWithFill (UIColor fillColor, nfloat radius, UIColor lineColor, nfloat lineWidth);
	}
}
