using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using MadsSDK;

namespace sample
{
	public class SampleViewController : UIViewController
	{
		readonly NSString zone = new NSString ("3327876051");
		readonly NSString secret = new NSString ("5AC993C91380875B");

		MadsAdView madsBannerView;
		MadsAdViewDelegate madsDelegate;

		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);

			if (madsBannerView == null) {
				PrepareMadsBannerView ();
				Add (madsBannerView);
			}
		}

		void PrepareMadsBannerView ()
		{

			madsDelegate = new SampleMadsDelegate ();
			madsBannerView = new MadsAdView (
				new RectangleF (0f, 0f, View.Frame.Size.Width, 54f),
				zone,
				secret,
				madsDelegate);
			madsBannerView.testMode = true;
		}

		#region MadsDelegate implementation
		class SampleMadsDelegate : MadsAdViewDelegate
		{	
			public override void AdDidCloseExpandFullScreen (MadsAdView view)
			{
				Console.WriteLine ("MadsDelegate AdDidCloseExpandFullScreen");
			}
			
			public override void AdDidCloseMessageUIFullScreen (MadsAdView view)
			{
				Console.WriteLine ("MadsDelegate AdDidCloseMessageUIFullScreen");
			}
			
			public override void AdDidCloseVideoFullScreen (MadsAdView view)
			{
				Console.WriteLine ("MadsDelegate AdDidCloseVideoFullScreen");
			}
			
			public override void AdDidEndFullScreen (MadsAdView view)
			{
				Console.WriteLine ("MadsDelegate AdDidEndFullScreen");
			}
			
			public override void AdDidResize (MadsAdView view)
			{
				Console.WriteLine ("MadsDelegate AdDidResize");
			}
			
			public override void AdDidUnresizeAd (MadsAdView view)
			{
				Console.WriteLine ("MadsDelegate AdDidUnresizeAd");
			}
			
			public override void AdShouldOpen (MadsAdView view, NSUrl url)
			{
				Console.WriteLine ("MadsDelegate AdShouldOpen");
			}
			
			public override void AdWillExpandFullScreen (MadsAdView view)
			{
				Console.WriteLine ("MadsDelegate AdWillExpandFullScreen");
			}
			
			public override void AdWillOpenMessageUIFullScreen (MadsAdView view)
			{
				Console.WriteLine ("MadsDelegate AdWillOpenMessageUIFullScreen");
			}
			
			public override void AdWillOpenVideoFullScreen (MadsAdView view)
			{
				Console.WriteLine ("MadsDelegate AdWillOpenVideoFullScreen");
			}
			
			public override void AdWillResize (MadsAdView view)
			{
				Console.WriteLine ("MadsDelegate AdWillResize");
			}
			
			public override void AdWillStartFullScreen (MadsAdView view)
			{
				Console.WriteLine ("MadsDelegate AdWillStartFullScreen");
			}
			
			public override void DidClosedAd (MadsAdView view, double usageTimeInterval)
			{
				Console.WriteLine ("MadsDelegate DidClosedAd");
			}
			
			public override void DidFailToReceiveAd (MadsAdView view, NSError error)
			{
				Console.WriteLine ("MadsDelegate DidFailToReceiveAd");
			}
			
			public override void DidReceiveAd (MadsAdView view)
			{
				Console.WriteLine ("MadsDelegate DidReceiveAd");
			}
			
			public override void MraidProcess (MadsAdView view, NSString e, NSDictionary param)
			{
				Console.WriteLine ("MadsDelegate MraidProcess");
			}
			
			public override void WillReceiveAd (MadsAdView view)
			{
				Console.WriteLine ("MadsDelegate WillReceiveAd");
			}
		}
		#endregion
	}
}

