using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            IWindow window = new BaseWindow();

            IWindow windowWith3D = new ThreeDimensionLightDecoration(window);
            IWindow windowWith3DAndColorfulFrame = new ColorfulFrameDecoration(windowWith3D);
            IWindow windowWith3DAndColorfulFrameAndSemiReflection = new SemiReflectionDecoration(windowWith3DAndColorfulFrame);
            IWindow windowWith3DAndColorfulFrameAndSemiReflectionAndShadowing = new ShadowingDecoration(windowWith3DAndColorfulFrameAndSemiReflection);
            IWindow windowWith3DAndColorfulFrameAndSemiReflectionAndShadowingAndFlickeringBackground = new FlickeringBackgroundDecoration(windowWith3DAndColorfulFrameAndSemiReflectionAndShadowing);

            Console.WriteLine(windowWith3DAndColorfulFrameAndSemiReflectionAndShadowingAndFlickeringBackground.GetDetails());

        }
    }
}
