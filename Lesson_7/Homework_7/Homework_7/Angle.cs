using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_7
{
    public class Angle
    {
        public int Degrees { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Angle()
        {
            
        }
        public Angle(int degrees, int minutes, int seconds)
        {
            this.Degrees = degrees;
            this.Minutes = minutes;
            this.Seconds = seconds;
        }

        public bool IsZero()
        {
            if(Degrees == 0 && Minutes == 0 && Seconds == 0)
            {
                return true;
            }

            return false;
        }

        public static bool operator < (Angle firstAngle, Angle secondAngle)
        {
            return ExecuteLogicOperator(firstAngle, secondAngle, "<");
        }

        public static bool operator > (Angle firstAngle, Angle secondAngle)
        {
            return ExecuteLogicOperator(firstAngle, secondAngle, ">");
        }

        public static bool operator == (Angle firstAngle, Angle secondAngle)
        {
            return ExecuteLogicOperator(firstAngle, secondAngle, "==");
        }

        public static bool operator != (Angle firstAngle, Angle secondAngle)
        {
            return ExecuteLogicOperator(firstAngle, secondAngle, "!=");
        }
        public static Angle operator + (Angle firstAngle, Angle secondAngle)
        {
            
            int degrees = firstAngle.Degrees + secondAngle.Degrees;
            int minutes = firstAngle.Minutes + secondAngle.Minutes;
            int seconds = firstAngle.Seconds + secondAngle.Seconds;

            
            TransformAngleValues(ref seconds, ref minutes);
            TransformAngleValues(ref minutes, ref degrees);

           return new Angle(degrees, minutes, seconds);
        }

        public static Angle operator * (Angle firstAngle, Angle secondAngle)
        {

            int degrees = firstAngle.Degrees * secondAngle.Degrees;
            int minutes = firstAngle.Minutes * secondAngle.Minutes;
            int seconds = firstAngle.Seconds * secondAngle.Seconds;


            TransformAngleValues(ref seconds, ref minutes);
            TransformAngleValues(ref minutes, ref degrees);

            return new Angle(degrees, minutes, seconds);
        }

        public static Angle operator - (Angle firstAngle, Angle secondAngle)
        {
            if(firstAngle > secondAngle)
            {
                int seconds = firstAngle.Seconds - secondAngle.Seconds;
                int minutes = firstAngle.Minutes - secondAngle.Minutes;
                int degrees = firstAngle.Degrees - secondAngle.Degrees;


                TransformAngleValues(ref seconds, ref minutes);
                TransformAngleValues(ref minutes, ref degrees);
                return new Angle(degrees, minutes, seconds);
            }
            else
            {
                throw new Exception("Can't decrease values. First value is less than second.");
            }
            
        }

        private static bool ExecuteLogicOperator(Angle firstAngle, Angle secondAngle, string operatorCharacter)
        {
            int firstAngleSeconds = firstAngle.Seconds + (firstAngle.Minutes * 60) + (firstAngle.Degrees * 3600);
            int secondAngleSeconds = secondAngle.Seconds + (secondAngle.Minutes * 60) + (secondAngle.Degrees * 3600);
            switch (operatorCharacter)
            {
                case "<": return firstAngleSeconds < secondAngleSeconds;
                case ">": return firstAngleSeconds > secondAngleSeconds;
                case "==": return firstAngleSeconds == secondAngleSeconds;
                case "!=": return firstAngleSeconds != secondAngleSeconds;
            }
            return false;
        }

        private static void TransformAngleValues(ref int valueToVerify, ref int valueToTransform)
        {
            while(valueToVerify > 60)
            {
                valueToTransform += 1;
                valueToVerify -= 60;
            }

            while(valueToVerify < 0)
            {
                valueToTransform -= 1;
                valueToVerify += 60;
            }
        }
    }
}
