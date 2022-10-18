using System;

namespace AvitCalculator_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            Evaluation eval = new Evaluation();

            Console.WriteLine("Enter a mathematical expression (e.g. 1+1): ");
            string expression = Console.ReadLine();

            var num = expression.Split(new Char[] { '+', '-', '/', '*', '(', ')' });

            var result = eval.Evaluate(expression, num);

            Console.WriteLine("The result is {0}", result.Pop());
            Console.ReadKey();
        }
    }
}
