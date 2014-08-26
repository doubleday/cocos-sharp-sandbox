using System;
using CocosSharp;

namespace CocosSharpSandbox
{
    public class TestLayer1 : CCLayerColor
    {
        const int CSF = SandboxApplicationDelegate.ContentScaleFactor;

        protected override void AddedToScene()
        {
            base.AddedToScene();
            var bg = new CCSprite("iphone5-bg.png");
            bg.Position = ContentSize.Center;
            AddChild(bg);

            var motor = new CCSprite("motor.png");
            motor.Position = new CCPoint(160, 240) * CSF;
            AddChild(motor);

            var roundedBorder = new CCScale9Sprite("circle.png");
            roundedBorder.CapInsets = new CCRect(50 * CSF, 50 * CSF, 1, 1);
            roundedBorder.PreferredSize = new CCSize(300 * CSF, 300 * CSF);
            roundedBorder.AnchorPoint = CCPoint.AnchorMiddle;
            roundedBorder.Position = ContentSize.Center;
            AddChild(roundedBorder);
        }

        public static CCScene Scene(CCWindow window)
        {
            var scene = new CCScene(window);

            var camera = new CCCamera(
                             CCCameraProjection.Projection2D, window.DesignResolutionSize * CSF
                         );

            var layer = new TestLayer1();
            layer.Camera = camera;

            scene.AddChild(layer);

            return scene;
        }
    }
}

