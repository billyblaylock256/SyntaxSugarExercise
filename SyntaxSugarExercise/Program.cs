using System;

namespace SyntaxSugarExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int answer = 4;
            //    string response;

            //    if (answer <9)
            //    {
            //        response = answer + "is less than nine";
            //    }
            //    else
            //    {
            //        response = answer + "greater than or equal to nine";
            //    }
            //    Console.WriteLine(response);

            var answer = 4;
            var response = "";

            response = (answer < 9) ? $"{answer} is less than 9" : $"{answer} is greater than nine";
            Console.WriteLine(response);
        }
    }
}
