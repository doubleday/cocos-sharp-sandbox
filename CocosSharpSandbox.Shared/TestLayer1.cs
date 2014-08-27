using System;
using CocosSharp;

namespace CocosSharpSandbox
{
    public class TestLayer1 : CCLayerColor
    {
        const float CSF = SandboxApplicationDelegate.ContentScaleFactor;

        protected override void AddedToScene()
        {
            base.AddedToScene();
            var bg = new CCSprite("iphone5-bg.png");
            bg.Position = ContentSize.Center;
            AddChild(bg);

            var motor = new CCSprite("motor.png");
            motor.Position = new CCPoint(160, 240);
            AddChild(motor);

            var roundedBorder = new CCScale9Sprite("circle.png", CCRect.Zero, new CCRect(50, 50, 1, 1));
            roundedBorder.PreferredSize = new CCSize(300, 300);
            roundedBorder.AnchorPoint = CCPoint.AnchorMiddle;
            roundedBorder.Position = ContentSize.Center;
            AddChild(roundedBorder);

            CCLabel label = new CCLabel("Motor", "Courier", 18 * CSF);
            label.AnchorPoint = CCPoint.AnchorMiddle;
            label.Color = CCColor3B.Red;
            label.Position = new CCPoint(160, motor.Position.Y + motor.ContentSize.Height / 2 + 10);

            AddChild(label);
        }

        public static CCScene Scene(CCWindow window)
        {
            var scene = new CCScene(window);

            var layer = new TestLayer1();
            scene.AddChild(layer);

            return scene;
        }
    }
}

