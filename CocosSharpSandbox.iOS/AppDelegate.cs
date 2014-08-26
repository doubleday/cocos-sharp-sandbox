using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using CocosSharp;

namespace CocosSharpSandbox.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        public override void FinishedLaunching(UIApplication app)
        {
            var application = new CCApplication();
            application.ApplicationDelegate = new SandboxApplicationDelegate();
            application.StartGame();
        }
    }
}

