using System;

namespace CouaCurves
{
    using CouaFloat = System.Single;
    public struct CouaVector2
    {
        public CouaFloat x;
        public CouaFloat y;

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

        public CouaCurve()
        {
            pointA = new CouaVector2(0f, 0f);
            pointB = new CouaVector2(0.33f, 0f);
            pointC = new CouaVector2(0.66f, 0f);
            pointD = new CouaVector2(1f, 0f);
        }
        public void SetPointAValue(CouaFloat v)
        {
            pointA.y = v;
        }
        public void SetPointBValue(CouaFloat v)
        {
            pointB.y = v;
        }
        public void SetPointCValue(CouaFloat v)
        {
            pointC.y = v;
        }
        public void SetPointDValue(CouaFloat v)
        {
            pointD.y = v;
        }
        public void SetPointBPosition(CouaFloat p)
        {
            pointB.x = p;
        }
        public void SetPointCPosition(CouaFloat p)
        {
            pointC.x = p;
        }
        public float EvaluateY(float t)
        {


            float omt = 1 - t;
            float eval = omt * (omt * (omt * pointA.y + t * pointB.y) + t * (omt * pointB.y + t * pointC.y)) + t * (omt * (omt * pointB.y + t * pointC.y) + t * (omt * pointC.y + t * pointD.y));
            return eval;
            //float eval = (1 - t) * ((1 - t) * ((1 - t) * pointA.y + t * pointB.y) + t * ((1 - t) * pointB.y + t * pointC.y)) + t * ((1 - t) * ((1 - t) * pointB.y + t * pointC.y) + t * ((1 - t) * pointC.y + t * pointD.y));

            #region Old
            //CouaFloat[] p = new CouaFloat[4] { pointA.y, pointB.y, pointC.y, pointD.y };
            //CouaFloat[] r1 = new CouaFloat[3];
            //CouaFloat[] r2 = new CouaFloat[2];

            //for (int i = 1; i < p.Length-1; i++)
            //{
            //    r1[i - 1] = (p[i - 1] + (p[i] - p[i - 1])) * t;
            //}
            //for (int i = 1; i < r1.Length - 1; i++)
            //{
            //    r2[i - 1] = (p[i - 1] + (p[i] - p[i - 1])) * t;
            //}
            //return (r2[0] + (r2[1] - r2[0])) * t;
            #endregion
        }
    }
}
