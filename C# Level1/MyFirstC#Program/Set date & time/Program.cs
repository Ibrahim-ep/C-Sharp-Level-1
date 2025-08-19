using System;

namespace Main
    {
        internal class Program
        {

        static void Main(string[] args)
        {

            //assigns default value 01/01/0001 00:00:00
            DateTime dt1 = new DateTime();

            //assigns year, month, day
            DateTime dt2 = new DateTime(2023, 12, 31);

            //assigns year, month, day, hour, min, seconds
            DateTime dt3 = new DateTime(2023, 12, 31, 5, 10, 20);

            //assigns year, month, day, hour, min, seconds, UTC timezone
            DateTime dt4 = new DateTime(2023, 12, 31, 5, 10, 20, DateTimeKind.Utc);

            Console.WriteLine(dt1);
            Console.WriteLine(dt2);
            Console.WriteLine(dt3);
            Console.WriteLine(dt4);

            dt1 = DateTime.Now;

            Console.WriteLine(dt1);


            DateTime dt = new DateTime(2023, 2, 21);

            // Hours, Minutes, Seconds
            TimeSpan ts = new TimeSpan(49, 25, 34);
            Console.WriteLine(ts);
            Console.WriteLine(ts.Days);
            Console.WriteLine(ts.Hours);
            Console.WriteLine(ts.Minutes);
            Console.WriteLine(ts.Seconds);

            //this will add time span to the date.
            DateTime newDate = dt.Add(ts);

            Console.WriteLine(newDate);

            DateTime BirthDate = new DateTime(2005, 10, 27);
            DateTime Now = new DateTime(2025, 8, 18);

            TimeSpan Result = Now.Subtract(BirthDate);

            System.Console.WriteLine(Result.Days);

            DateTime dt5 = new DateTime(2015, 12, 20);
            DateTime dt6 = new DateTime(2016, 12, 31, 5, 10, 20);
            TimeSpan time = new TimeSpan(10, 5, 25, 50);

            Console.WriteLine(dt6 + time); // 1/10/2017 10:36:10 AM
            Console.WriteLine(dt6 - dt5); //377.05:10:20
            Console.WriteLine(dt5 == dt6); //False
            Console.WriteLine(dt5 != dt6); //True
            Console.WriteLine(dt5 > dt6); //False
            Console.WriteLine(dt5 < dt6); //True
            Console.WriteLine(dt5 >= dt6); //False
            Console.WriteLine(dt5 <= dt6);//True
            

            System.Console.WriteLine("----------------------");
            
            var str = "6/12/2023";
            DateTime to_dt;

            var isValidDate = DateTime.TryParse(str, out to_dt);

            if (isValidDate)
                Console.WriteLine(to_dt);
            else
                Console.WriteLine($"{str} is not a valid date string");

            //invalid string date
            var str2 = "6/65/2023";
            DateTime to_dt2;

            var isValidDate2 = DateTime.TryParse(str2, out to_dt2);

            if (isValidDate2)
                Console.WriteLine(to_dt2);
            else
                Console.WriteLine($"{str2} is not a valid date string");
        }
        }
    }