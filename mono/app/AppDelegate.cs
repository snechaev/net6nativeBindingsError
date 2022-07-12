using AppKit;
using Foundation;
using ScriptingBridge;
using NativeBindingsLib;

namespace app
{
	[Register ("AppDelegate")]
	public class AppDelegate : NSApplicationDelegate
	{
		public AppDelegate ()
		{
		}

		public override void DidFinishLaunching (NSNotification notification)
		{
			// Insert code here to initialize your application

			var app = SBApplication.GetApplication<FinderApplication>("com.apple.finder");
			var version = app.Version;
			using (var alert = new NSAlert())
			{
				alert.InformativeText = version.ToString();
				alert.RunModal();
			}


		}

		public override void WillTerminate (NSNotification notification)
		{
			// Insert code here to tear down your application
		}
	}
}

