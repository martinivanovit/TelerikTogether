﻿using System;
using System.Windows;

namespace TelerikTogether
{
    public static class RadMath
    {
        /// <summary>
        /// The factor used to convert degrees to their radians equivalent.
        /// </summary>
        public const double DegToRadFactor = Math.PI / 180;

        public static double DaiPet()
        {
            return 5;
        }

        public static double NapraviNeshto()
        {
            return 23; 
        }

        public static Point GetArcPoint(double angle, Point center, double radius)
        {
            double angleInRad = angle * RadMath.DegToRadFactor;

            double x = center.X + (Math.Cos(angleInRad) * radius);
            double y = center.Y + (Math.Sin(angleInRad) * radius);

            return new Point(x, y);
        }
    }
}
