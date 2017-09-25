using System;


namespace _06.BonusScore
{
    class BonusScore
    {
        static void Main()
        {
            int score = int.Parse(Console.ReadLine());

            double bonusScore = 0;

            if (score <= 100)
            {
                bonusScore = 5;
            }
            else if (score <= 1000)
            {
                bonusScore = score * 0.2;
            }
            else if (score > 1000)
            {
                bonusScore = score * 0.1;
            }

            if (score % 2 == 0) //chetno
            {
                bonusScore += 1;
            }
            else if (score % 10 == 5) // - ostatyk 5 /(score % 5 == 0) 
            {
                bonusScore += 2;
            }
            Console.WriteLine(bonusScore);

            double totalScore = score + bonusScore;

            Console.WriteLine(totalScore);
        }
    }
}
