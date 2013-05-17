using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace sample
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		UIWindow window;
		SampleViewController viewController;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			window = new UIWindow (UIScreen.MainScreen.Bounds);

			StartMadsAdServer ();
			
			viewController = new SampleViewController ();
			window.RootViewController = viewController;
			window.MakeKeyAndVisible ();
			
			return true;
		}

		public override void WillEnterForeground (UIApplication application)
		{
			StartMadsAdServer ();
		}
		
		public override void DidEnterBackground (UIApplication application)
		{
			MadsSDK.MadsAdServer.Stop ();
		}

		static void StartMadsAdServer ()
		{
			MadsSDK.MadsAdServer.Start (true, true);
		}
	}
}

