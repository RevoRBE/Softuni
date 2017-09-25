using System;

namespace _20.MatchTickets
{
    class MatchTickets
    {
        static void Main()
        {
            double budget = Double.Parse(Console.ReadLine());
            string category = Console.ReadLine().ToLower();
            int people = int.Parse(Console.ReadLine());

            if (people > 0 && people <= 4)
            {
                double transport = budget * 0.75;
                double remainder = budget - transport;
                if (category == "normal" )
                {
                    double ticket = 249.99 * people;
                    if (ticket < remainder)
                    {
                        double left = remainder - ticket;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", left);
                    }
                    else
                    {
                        double need = ticket - remainder;
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", need);
                    }
                }
                else if (category == "vip")
                {
                    double ticket = 499.99 * people;
                    if (remainder > ticket)
                    {
                        double left = remainder - ticket;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", left);
                    }
                    else
                    {
                        double need = ticket - remainder;
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", need);
                    }
                }
            }
            else if (people <= 9)
            {
                double transport = budget * 0.60;
                double remainder = budget - transport;
                if (category == "normal")
                {
                    double ticket = 249.99 * people;
                    if (ticket < remainder)
                    {
                        double left = remainder - ticket;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", left);
                    }
                    else
                    {
                        double need = remainder - ticket;
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", need);
                    }
                }
                else if (category == "vip")
                {
                    double ticket = 499.99 * people;
                    if (remainder > ticket)
                    {
                        double left = remainder - ticket;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", left);
                    }
                    else
                    {
                        double need = ticket - remainder;
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", need);
                    }
                }
            }
            else if (people <= 24)
            {
                double transport = budget * 0.50;
                double remainder = budget - transport;
                if (category == "normal")
                {
                    double ticket = 249.99 * people;
                    if (ticket < remainder)
                    {
                        double left = remainder - ticket;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", left);
                    }
                    else
                    {
                        double need = remainder - ticket;
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", need);
                    }
                }
                else if (category == "vip")
                {
                    double ticket = 499.99 * people;
                    if (remainder > ticket)
                    {
                        double left = remainder - ticket;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", left);
                    }
                    else
                    {
                        double need = ticket - remainder;
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", need);
                    }
                }
            }
            else if (people <= 49)
            {
                double transport = budget * 0.40;
                double remainder = budget - transport;
                if (category == "normal")
                {
                    double ticket = 249.99 * people;
                    if (ticket < remainder)
                    {
                        double left = remainder - ticket;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", left);
                    }
                    else
                    {
                        double need = ticket - remainder;
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", need);
                    }
                }
                else if (category == "vip")
                {
                    double ticket = 499.99 * people;
                    if (remainder > ticket)
                    {
                        double left = remainder - ticket;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", left);
                    }
                    else
                    {
                        double need = ticket - remainder;
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", need);
                    }
                }
            }
            else if (people > 49)
            {
                double transport = budget * 0.25;
                double remainder = budget - transport;
                if (category == "normal")
                {
                    double ticket = 249.99 * people;
                    if (ticket < remainder)
                    {
                        double left = remainder - ticket;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", left);
                    }
                    else
                    {
                        double need = ticket - remainder;
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", need);
                    }
                }
                else if (category == "vip")
                {
                    double ticket = 499.99 * people;
                    if (remainder > ticket)
                    {
                        double left = remainder - ticket;
                        Console.WriteLine("Yes! You have {0:f2} leva left.", left);
                    }
                    else
                    {
                        double need = ticket - remainder;
                        Console.WriteLine("Not enough money! You need {0:f2} leva.", need);
                    }
                }
            }
        }
    }
}
