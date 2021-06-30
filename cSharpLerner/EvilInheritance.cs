using System;
using System.Collections.Generic;
using System.Text;

namespace cSharpLerner
{
    public interface iShape
    {
        int CalcSquare();

    }


   public class Rect: iShape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public int CalcSquare()
        {
            throw new NotImplementedException();
        }
    }
    public class Square : iShape
    {   public int SideLength { get; set; }
        public int CalcSquare()
        {


            return SideLength * SideLength;
        }
    }
    public static class AreaCalculator
    {

    }
}
