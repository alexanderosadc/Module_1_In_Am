using System;

namespace Homework_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle firstAngle = new Angle(1, 0, 0);
            Angle secondAngle = new Angle(0, 3, 3);
            Angle result = firstAngle + secondAngle;
            Console.WriteLine(result.Degrees + " degree, " + result.Minutes + " minutes, " + result.Seconds + " seconds");
        }
    }
}
