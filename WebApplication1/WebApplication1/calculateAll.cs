using System;

namespace WebApplication1
{
    public class calculateAll
    {
        private static double ToDegree(double angle)
        {
            return angle * (180.0 / Math.PI);
        }

        private static double ToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }

        public double[] Time(double initHeight, double initSpeed, double deg)
        {
            double[] arr = new double[3];
            double Cos = Math.Cos(ToRadian(deg)), Sin = Math.Sin(ToRadian(deg));
            double tImpact, dist, t, hitDeg, vImpact, g = 9.81, a, b, c, num1, num2;
            b = initSpeed * Sin;
            a = g / -2;
            c = initHeight;

            num1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            num2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);

            if (num1 > 0)
            {
                tImpact = num1;
            }
            else
            {
                tImpact = num2;
            }

            vImpact = VImpact(tImpact, initSpeed, deg);
            dist = Dist(deg, initSpeed, initHeight);

            if (initHeight == 0)
            {
                hitDeg = 180 - deg;
            }
            else
            {
                t = Math.Sqrt(2 * initHeight / g);
                hitDeg = ToDegree(Math.Atan((initSpeed * Cos) / g * t));
            }

            arr[0] = dist;
            arr[1] = vImpact;
            arr[2] = hitDeg;

            return arr;
        }

        public static double Dist(double deg, double initSpeed, double initHeight)
        {
            double g = 9.81;
            double dist = (((Math.Pow(initSpeed, 2) * Math.Sin(ToRadian(deg * 2)))) / g) + (initSpeed * Math.Sqrt(2 * initHeight / g));
            return dist;
        }

        public static double VImpact(double tImpact, double initSpeed, double deg)
        {
            double Cos = Math.Cos(ToRadian(deg)), Sin = Math.Sin(ToRadian(deg)), g = 9.81;
            double vImpact = Math.Sqrt(Math.Pow((initSpeed * Cos), 2) + Math.Pow((-(g * tImpact) + initSpeed * Sin), 2));
            return vImpact;
        }
    }
}