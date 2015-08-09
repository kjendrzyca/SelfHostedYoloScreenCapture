﻿namespace SelfHostedYoloScreenCapture.Drawing
{
    using System;
    using System.Drawing;

    class StaticHelper
    {
        public static Rectangle GetRectangle(Point startLocation, Point endLocation)
        {
            var startX = Math.Min(startLocation.X, endLocation.X);
            var startY = Math.Min(startLocation.Y, endLocation.Y);
            var endX = Math.Max(startLocation.X, endLocation.X);
            var endY = Math.Max(startLocation.Y, endLocation.Y);

            return new Rectangle(new Point(startX, startY), new Size(endX - startX, endY - startY));
        }
    }
}