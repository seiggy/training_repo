using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace GitTraining
{
    internal class Calculator
    {
        public static async Task<string> Parse(string input)
        {
            return (await CSharpScript.EvaluateAsync(input)).ToString();
        }
    }
}