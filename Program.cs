using System;

namespace beans
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Beans calculator (cuz its shit)";
            Console.ForegroundColor = ConsoleColor.Green;
            double num1;
            double num2;
            double num3;

            Console.WriteLine("Number 1:");
            num1 = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Don't be lazy, whats the second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Almost done, one more number: ");
            num3 = Convert.ToDouble(Console.ReadLine());

            double beans = num1 + num2 + num3;
            double beans2 = beans / 3;

            Console.WriteLine("Heres the anwser Happy? average number between all three: " + beans2);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
            
        }
    }
}