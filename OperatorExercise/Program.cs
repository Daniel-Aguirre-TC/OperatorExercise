using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int remainder = a % b;
            Console.WriteLine($"{a}/{b} is {a/b} {nameof(remainder)} {remainder}");
            Console.WriteLine("Now we will get the area of a circle.");
            AskForRadius();            
        }

        public static void AreaOfCircle(double radius)
        {
            Console.WriteLine(radius * radius * Math.PI);
        }

        public static void AskForRadius()
        {
            Console.WriteLine("Please enter a radius. Non-numerical values are not accepted.");
            if (Double.TryParse(Console.ReadLine(), out double input))
                AreaOfCircle(input);
            else
            {
                AskForRadius();
            }
        }
    }
}
