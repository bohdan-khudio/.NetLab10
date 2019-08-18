using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson1
{
    class Validator
    {
        public static bool CheckRectangle(Coordinate A, Coordinate C)
        {
            if ((A.X > C.X) || (A.Y < C.Y)) return false;
            else return true;
        }

        public static bool CheckCircle(int r)
        {
            if (r < 0) return false;
            else return true;
        }
    }
}
