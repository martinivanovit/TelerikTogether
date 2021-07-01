using System.Windows;

namespace TelerikTogether.Math
{
    public static class RadMath
    {
        /// <summary>
        /// The factor used to convert degrees to their radians equivalent.
        /// </summary>
        public const double DegToRadFactor = System.Math.PI / 180;

        public static double DaiPet()
        {
            return 15;
        }

        public static double NapraviNeshto()
        {
            return 23; 
        }

        public static RadPoint GetArcPoint(double angle, RadPoint center, double radius)
        {
            double angleInRad = angle * RadMath.DegToRadFactor;

            double x = center.X + (System.Math.Cos(angleInRad) * radius);
            double y = center.Y + (System.Math.Sin(angleInRad) * radius);

            return new RadPoint(x, y);
        }
    }
}
