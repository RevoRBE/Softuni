using System;


namespace _17.OnTimeForTheExam
{
    class OnTimeForTheExam
    {
        static void Main()
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int arrHour = int.Parse(Console.ReadLine());
            int arrMin = int.Parse(Console.ReadLine());

            int examTotalMin = examHour * 60 + examMin;
            int arrTotalMin = arrHour * 60 + arrMin;

            if (examTotalMin == arrTotalMin)
            {
                Console.WriteLine("On time");
            }
            else if (examTotalMin > arrTotalMin)
            {
                int diffMin = examTotalMin - arrTotalMin;
                if (diffMin <= 30)
                {
                    Console.WriteLine("On time \n{0} minutes before the start", diffMin);
                }
                else if (diffMin <= 59)
                {
                    Console.WriteLine("Early \n{0} minutes before the start", diffMin);
                }
                else if (diffMin >= 60)
                {
                    int hours = diffMin / 60;
                    int min = diffMin % 60;
                    Console.WriteLine("Early \n{0}:{1:00} hours before the start", hours, min);
                }
            }
            else if (examTotalMin < arrTotalMin)
            {
                int diffMin = arrTotalMin - examTotalMin;
                if (diffMin < 60)
                {
                    Console.WriteLine("Late \n{0} minutes after the start", diffMin);
                }
                else if (diffMin >= 60)
                {
                    int hours = diffMin / 60;
                    int min = diffMin % 60;
                    Console.WriteLine("Late \n{0}:{1:00} hours after the start", hours, min);
                }
            }
        }
    }
}
