using System;
using CocosSharp;

namespace CocosSharpSandbox
{
    public class SandboxApplicationDelegate : CCApplicationDelegate
    {
        // 1: standard, 2: retina
        public const float ContentScaleFactor = 1;

        public override void ApplicationDidFinishLaunching(CCApplication application, CCWindow mainWindow)
        {
            application.PreferMultiSampling = false;
            application.ContentRootDirectory = "Content";

            mainWindow.SupportedDisplayOrientations = CCDisplayOrientation.Portrait;
            mainWindow.SetDesignResolutionSize(320, 480, CCSceneResolutionPolicy.ShowAll);

            CCSprite.DefaultTextureToContentScale = 1 / ContentScaleFactor;
            if (ContentScaleFactor > 1)
            {
                application.ContentSearchPaths.Add("hd");
            }
            else
            {
                application.ContentSearchPaths.Add("ld");
            }

            CCSpriteFrameCache.SharedSpriteFrameCache.AddSpriteFrames("sprites.plist");

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

