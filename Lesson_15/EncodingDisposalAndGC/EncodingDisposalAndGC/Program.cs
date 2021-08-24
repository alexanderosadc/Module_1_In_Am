using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace EncodingDisposalAndGC
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoding utf8 = Encoding.UTF8;
            Encoding ascii = Encoding.ASCII;
            Encoding utf32 = Encoding.UTF32;

            string text = "Hello World!";
            byte[] byteUtf8 = utf8.GetBytes(text);
            byte[] byteAscii = ascii.GetBytes(text);
            byte[] byteUtf32 = utf32.GetBytes(text);

            using(FileStream fs = File.Create("test.txt"))
            {
                fs.Write(byteUtf8);
                fs.Write(byteAscii);
                fs.Write(byteUtf32);
            }

            if(text.StartsWith("Hello"))
            {
                text = text.Remove(0, "Hello".Length);
                text = text.Insert(0, "Goodbuy");
            }

            string paragraph = "{1, -10} When we are born we have instance thought {0, 20}";
            string formatedText = string.Format(paragraph, text, "ehhhh");
            Console.WriteLine(text.Equals(formatedText, StringComparison.InvariantCultureIgnoreCase));

            DateTime examDate = new DateTime(2021, 8, 4);
            DateTime currentDate = DateTime.Now;
            long remainingTimeTicks = examDate.Ticks - currentDate.Ticks;
            TimeSpan examTimeSpan = TimeSpan.FromTicks(remainingTimeTicks);


            DateTimeOffset examDayOffset= new DateTimeOffset(examDate);
            Console.WriteLine($"Current datetime {examDayOffset}, {examDayOffset.UtcDateTime}.");

            DateTime examDateJapan = TimeZoneInfo.ConvertTime(examDate, TimeZoneInfo.FindSystemTimeZoneById("Tokyo Standard Time"));
            Console.WriteLine($"Exam date Arizona {examDateJapan}");

            CultureInfo japanCultureInfo = new CultureInfo("ja-JP");
            Console.WriteLine(30.ToString(japanCultureInfo));

            NumberFormatInfo numberFormat = new NumberFormatInfo();

            numberFormat.NumberDecimalSeparator = ",";
            numberFormat.NegativeSign = "?";
            numberFormat.PositiveSign = "!";

            Console.WriteLine((-30.20).ToString(numberFormat));

            FileStream fileStream = File.Create("test1.txt");
            byte[] byteArr = utf8.GetBytes("HelloWorld");
            fileStream.Write(byteArr);
            fileStream.Dispose();

            Enemy enemy = new Enemy(30);
        }
    }
}
