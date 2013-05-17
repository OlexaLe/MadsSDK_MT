using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace MadsSDK
{
	[BaseType (typeof(NSObject))]
	interface MadsAdServer
	{
		[Static, Export("startWithLocationEnabled:withAppTargetingEnabled:")]
		void Start (bool enableLocation, bool enableApptargeting);

		[Static, Export("stop")]
		void Stop ();

		[Static, Export ("locationServicesEnabled")]
		bool LocationServicesEnabled { get; }

		[Static, Export ("appTargetingEnabled")]
		bool AppTargetingEnabled { get; }
	}
	
	[BaseType (typeof(UIView))]
	interface MadsAdView
	{
		[Export ("initWithFrame:zone:secret:delegate:")]
		IntPtr Constructor (RectangleF frame, NSString zone, NSString secret, MadsAdViewDelegate del);
		
		[Export ("update")]
		void Update ();

		[Export ("stopLoading")]
		void stopLoading ();
		
		[Export ("testMode")]
		bool testMode { get; set; }
		
		[Export ("logMode")]
		MadsAdLogMode logMode { get; set; }

		[Export ("zone", ArgumentSemantic.Retain)]
		NSString zone { get; set; }

		[Export ("secret", ArgumentSemantic.Retain)]
		NSString secret { get; set; }

		[Export ("madsAdType", ArgumentSemantic.Assign)]
		MadsAdType madsAdType { get; set; }

		[Export ("animationType", ArgumentSemantic.Assign)]
		MadsAdAnumationType animationType { get; set; }

		[Export ("contentSize")]
		RectangleF contentSize { get; }

		[Export ("defaultImage", ArgumentSemantic.Retain)]
		UIImage defaultImage { get; set; }

		[Export ("autoCollapse")]
		bool autoCollapse { get; set; }

		[Export ("showPreviousAdOnError")]
		bool showPreviousAdOnError { get; set; }

		[Export ("closeButton", ArgumentSemantic.Retain)]
		UIButton closeButton { get; set; }

		[Export ("autocloseInterstitialTime")]
		double autocloseInterstitialTime { get; set; }

		[Export ("updateTimeInterval")]
		double updateTimeInterval { get; set; }

		[Export ("adServerUrl", ArgumentSemantic.Retain)]
		NSString adServerUrl { get; set; }

		[Export ("adCallTimeout", ArgumentSemantic.Assign)]
		int adCallTimeout { get; set; }

		[Export ("contentAlignment")]
		bool contentAlignment { get; set; }

		[Export ("minSize")]
		SizeF minSize { get; set; }

		[Export ("maxSize")]
		SizeF maxSize { get; set; }

		[Export ("track")]
		bool track { get; set; }

		[Export ("useInternalBrowser")]
		bool useInternalBrowser { get; set; }

		[Export ("useRootViewControllerForExpandAndInternalBrowser")]
		bool useRootViewControllerForExpandAndInternalBrowser { get; set; }

		[Export ("textColor", ArgumentSemantic.Retain)]
		UIColor textColor { get; set; }

		[Export ("isLoading")]
		bool isLoading { get; }

		[Wrap ("WeakDelegate")]
		[NullAllowed]
		MadsAdViewDelegate Delegate { get; set; }

		[Export ("delegate", ArgumentSemantic.Assign)]
		[NullAllowed]
		NSObject WeakDelegate { get; set; }
	}

	[BaseType (typeof(NSObject))]
	[Model]
	interface MadsAdViewDelegate
	{
		[Export("willReceiveAd:")]
		void WillReceiveAd (MadsAdView view);

		[Export("didReceiveAd:")]
		void DidReceiveAd (MadsAdView view);

		[Export("didFailToReceiveAd:withError:")]
		void DidFailToReceiveAd (MadsAdView view, NSError error);

		[Export("adWillStartFullScreen:")]
		void AdWillStartFullScreen (MadsAdView view);

		[Export("adDidEndFullScreen:")]
		void AdDidEndFullScreen (MadsAdView view);

		[Export("adWillExpandFullScreen:")]
		void AdWillExpandFullScreen (MadsAdView view);

		[Export("adDidCloseExpandFullScreen:")]
		void AdDidCloseExpandFullScreen (MadsAdView view);

		[Export("adWillResize:")]
		void AdWillResize (MadsAdView view);

		[Export("adDidResize:")]
		void AdDidResize (MadsAdView view);

		[Export("adDidUnresizeAd:")]
		void AdDidUnresizeAd (MadsAdView view);

		[Export("adWillOpenVideoFullScreen:")]
		void AdWillOpenVideoFullScreen (MadsAdView view);

		[Export("adDidCloseVideoFullScreen:")]
		void AdDidCloseVideoFullScreen (MadsAdView view);

		[Export("adWillOpenMessageUIFullScreen:")]
		void AdWillOpenMessageUIFullScreen (MadsAdView view);

		[Export("adDidCloseMessageUIFullScreen:")]
		void AdDidCloseMessageUIFullScreen (MadsAdView view);

		[Export("adShouldOpen:withUrl:")]
		void AdShouldOpen (MadsAdView view, NSUrl url);

		[Export("didClosedAd:usageTimeInterval:")]
		void DidClosedAd (MadsAdView view, double usageTimeInterval);

		[Export("mraidProcess:event:parameters:")]
		void MraidProcess (MadsAdView view, NSString e, NSDictionary param);
	}
}

