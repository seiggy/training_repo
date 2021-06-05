using System;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace GitTraining
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Write(">");
            var input = Console.ReadLine();
            Console.WriteLine(await Calculator.Parse(input));

            Console.ReadKey();
        }
    }

    internal class Calculator
    {
        public static async Task<string> Parse(string input)
        {
            return (await CSharpScript.EvaluateAsync(input)).ToString();
        }
    }
}
