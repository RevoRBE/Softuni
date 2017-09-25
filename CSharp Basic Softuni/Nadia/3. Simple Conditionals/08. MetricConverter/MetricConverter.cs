using System;


namespace _08.MetricConverter
{
    class MetricConverter
    {
        static void Main()
        {
            double value = double.Parse(Console.ReadLine());
            string met1 = Console.ReadLine();
            string met2 = Console.ReadLine();
            double millimeters = 1000;
            double centimeters = 100;
            double miles = 0.000621371192;
            double inches = 39.3700787;
            double kilometers = 0.001;
            double feet = 3.2808399;
            double yards = 1.0936133;

            switch (met1)
            {
                case "m":
                    break;
                case "mm":
                    value /= millimeters;
                    break;
                case "cm":
                    value /= centimeters;
                    break;
                case "mi":
                    value /= miles;
                    break;
                case "in":
                    value /= inches;
                    break;
                case "km":
                    value /= kilometers;
                    break;
                case "ft":
                    value /= feet;
                    break;
                case "yd":
                    value /= yards;
                    break;
            }
            switch (met2)
            {
                case "m":
                    break;
                case "mm":
                    val *=  millimeters;
                    break;
                case "cm":
                    val *=  centimeters;
                    break;
                case "mi":
                    val *=  miles;
                    break;
                case "in":
                    val *=  inches;
                    break;
                case "km":
                    val *=  kilometers;
                    break;
                case "ft":
                    val *=  feet;
                    break;
                case "yd":
                    val *=  yards;
                    break;
            }
            Console.WriteLine(value);
        }
    }
}
