using System;

namespace cSharpLerner
{
    public struct EvilStruct
    {
        public int x;
        public int y;

        public PointRef PointRef;
    }
    public struct PointVal
    {
        public int x;
        public int y;

        public void LogValues()
        {
            Console.WriteLine($"x {x}, y{y}");
        }
    }
    public class PointRef
    {
        public int x;
        public int y;

        public void LogValues()
        {
            Console.WriteLine($"x {x}, y{y}");
        }
    }
}