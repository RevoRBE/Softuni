using System;

class PersonalTitles
{
    static void Main()
    {
        double age = double.Parse(Console.ReadLine());
        string gender = Console.ReadLine();
        //bool isMale = gender == "m";
        //bool isAdult = age >= 16;
        //Console.WriteLine(isAdult ? isMale ? "Mr." : "Ms." : isMale ? "Master" : "Miss");
        Console.WriteLine(age < 16 ? gender == "m" ? "Master" : "Miss" : gender == "m" ? "Mr." : "Ms.");
    }
}
