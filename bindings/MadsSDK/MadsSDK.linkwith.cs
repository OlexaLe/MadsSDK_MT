using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith ("MadsSDK.a", LinkTarget.Simulator | LinkTarget.ArmV7, 
                     Frameworks = "CoreLocation CoreTelephony EventKit MediaPlayer MessageUI SystemConfiguration", 
                     WeakFrameworks = "AdSupport", 
                     ForceLoad = true
)]
