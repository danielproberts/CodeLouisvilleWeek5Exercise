using System;

namespace CodeLouisvilleWeek5Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = @"https://www.boredapi.com/api/activity";
            BoredData data = new BoredData();
            data = data.pullData(url);

            Console.WriteLine();
            StringExtensions.CenterTitle("BoredAPI Activity Suggestion");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Name of Activity: ");
            Console.WriteLine(data.Activity);

            Console.Write("Type of Activity: ");
            Console.WriteLine(StringExtensions.FirstCharToUpper(data.Type));
            //Console.WriteLine(data.Type);


            Console.Write("Number of Participants: ");
            Console.WriteLine(data.Participants);
            Console.ReadKey();
        }
    }
}
