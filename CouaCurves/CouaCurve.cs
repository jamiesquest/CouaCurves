using System;

namespace CouaCurves
{
    using CouaFloat = System.Single;
    public struct CouaVector2
    {
        internal CouaFloat x;
        internal CouaFloat y;

        public CouaVector2(CouaFloat x, CouaFloat y)
        {
            this.x = x;
            this.y = y;
        }

        public static bool operator ==(CouaVector2 a, CouaVector2 b)
        {
            return a.x == b.x && a.y == b.y;
        }
        public static bool operator !=(CouaVector2 a, CouaVector2 b)
        {
            return a.x != b.x || a.y != b.y;
        }

        public static CouaVector2 operator +(CouaVector2 a, CouaVector2 b)
        {
            return new CouaVector2(a.x + b.x, a.y + b.y);
        }
        public static CouaVector2 operator -(CouaVector2 a, CouaVector2 b)
        {
            return new CouaVector2(a.x - b.x, a.y - b.y);
        }

        public static CouaVector2 Zero { get { return new CouaVector2(0f, 0f); } }
        public static CouaVector2 One { get { return new CouaVector2(1f, 1f); } }
    }



    public class CouaCurve
    {
        CouaVector2 pointA, pointB, pointC, pointD;



    }
}
