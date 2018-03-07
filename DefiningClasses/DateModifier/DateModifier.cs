using System;

public class DateModifier
{
     public static void DatesDifference(string date1s, string date2s)
     {
         var StartDate = DateTime.Parse(date1s);
         var EndDate = DateTime.Parse(date2s);
         Console.WriteLine(Math.Abs((EndDate - StartDate).TotalDays));
     }
}