using System;
using CocosSharp;

namespace CocosSharpSandbox
{
    public class SandboxApplicationDelegate : CCApplicationDelegate
    {
        public const int ContentScaleFactor = 2;

        public override void ApplicationDidFinishLaunching(CCApplication application, CCWindow mainWindow)
        {
            application.PreferMultiSampling = false;
            application.ContentRootDirectory = "Content";

            mainWindow.SupportedDisplayOrientations = CCDisplayOrientation.Portrait;
            mainWindow.SetDesignResolutionSize(320, 480, CCSceneResolutionPolicy.ShowAll);

            if (ContentScaleFactor > 1)
            {
                application.ContentSearchPaths.Add("hd");
            }
            else
            {
                application.ContentSearchPaths.Add("ld");
            }

            CCScene scene = TestLayer1.Scene(mainWindow);
            mainWindow.RunWithScene(scene);
        }

        public override void ApplicationDidEnterBackground(CCApplication application)
        {
            application.Paused = true;
        }

        public override void ApplicationWillEnterForeground(CCApplication application)
        {
            application.Paused = false;
        }
    }
}

