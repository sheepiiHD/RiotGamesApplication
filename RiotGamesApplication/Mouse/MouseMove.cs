using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


//Credits go to http://stackoverflow.com/questions/913646/c-sharp-moving-the-mouse-around-realistically
//User named "Matt"
//Slightly altered so I can have syncronized events. 
namespace RiotGamesApplication
{
    class MouseMove
    {


        static void MoveMouse(Point newPosition, int steps)
        {
            Point start = GetCursorPos(System.Windows.Forms.Cursor.Position);
            PointF iterPoint = start;

            // Find the slope of the line segment defined by start and newPosition
            PointF slope = new PointF(newPosition.X - start.X, newPosition.Y - start.Y);

            // Divide by the number of steps
            slope.X = slope.X / steps;
            slope.Y = slope.Y / steps;

            // Move the mouse to each iterative point.
            for (int i = 0; i < steps; i++)
            {
                iterPoint = new PointF(iterPoint.X + slope.X, iterPoint.Y + slope.Y);
                SetCursorPos(Point.Round(iterPoint));
                Thread.Sleep(1000);
            }

            // Move the mouse to the final destination.
            SetCursorPos(newPosition);
        }

        [DllImport("user32.dll")]
        static extern bool SetCursorPos(PointF p);

        [DllImport("user32.dll")]
        public static extern bool GetCursorPos(out Point p);
    }
}
