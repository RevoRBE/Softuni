using System;


namespace _08.TradeComissions
{
    class TradeComissions
    {
        static void Main()
        {
            string city = Console.ReadLine().ToLower();
            double sales = double.Parse(Console.ReadLine());
            double result = 0.0;

            switch (city)
            {
                case "sofia":
                    if (sales >= 0 && sales <= 500)
                    {
                        result = sales * 0.05;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        result = sales * 0.07;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        result = sales * 0.08;
                    }
                    else if(sales > 10000)
                    {
                        result = sales * 0.12;
                    }
                    break;
                case "plovdiv": 
                    if (sales >= 0 && sales <= 500)
                    {
                        result = sales * 0.055;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        result = sales * 0.08;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        result = sales * 0.12;
                    }
                    else if (sales > 10000)
                    {
                        result = sales * 0.145;
                    }
                    break;
                case "varna": 
                    if (sales >= 0 && sales <= 500)
                    {
                        result = sales * 0.045;
                    }
                    else if (sales > 500 && sales <= 1000)
                    {
                        result = sales * 0.075;
                    }
                    else if (sales > 1000 && sales <= 10000)
                    {
                        result = sales * 0.1;
                    }
                    else if (sales > 10000)
                    {
                        result = sales * 0.13;
                    }
                    break;
            }
            if (result != 0)
            {
                Console.WriteLine("{0:f2}", result); //$"(result:f2)"
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
