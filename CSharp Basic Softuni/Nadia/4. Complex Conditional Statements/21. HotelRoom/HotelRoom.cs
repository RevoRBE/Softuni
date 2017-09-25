using System;


namespace _21.HotelRoom
{
    class HotelRoom
    {
        static void Main()
        {
            string month = Console.ReadLine().ToLower();
            int nights = int.Parse(Console.ReadLine());

            double studio = 0.0;
            double apartment = 0.0;

            if (month == "may" || month == "october")
            {
                if (nights > 1 && nights <= 7)
                {
                    studio = 50 * nights;
                    apartment = 65 * nights;
                }
                else if (nights > 7 && nights <=14)
                {
                    studio = (50 - (50 * 0.05)) * nights;
                    apartment = 65 * nights;
                }
                else
                {
                    studio = (50 - (50 * 0.3)) * nights;
                    apartment = (65 - (65 * 0.1)) * nights;
                }
            }
            else if (month == "june" || month == "september")
            {
                if (nights > 1 && nights <= 14)
                {
                    studio = 75.20 * nights;
                    apartment = 68.70 * nights;
                }
                else 
                {
                    studio = (75.20 - (75.20 * 0.2)) * nights;
                    apartment = (68.70 - (68.70 * 0.1)) * nights;
                }
            }
            else if (month == "july" || month == "august")
            {
                if (nights > 1 && nights <= 14)
                {
                    studio = 76 * nights;
                    apartment = 77 * nights;
                }
                else
                {
                    studio = 76 * nights;
                    apartment = (77 -(77 * 0.1)) * nights;
                }
            }
            Console.WriteLine("Apartment: {0:f2} lv.", apartment);
            Console.WriteLine("Studio: {0:f2} lv.", studio);
        }
    }
}
