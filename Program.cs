using System;
using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace GitTraining
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("§");
            Console.ForegroundColor = ConsoleColor.White;
            var input = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
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
