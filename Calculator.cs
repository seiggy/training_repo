using System.Threading.Tasks;
using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace GitTraining
{
    public class Calculator
    {
        public static async Task<string> Parse(string input)
        {
            return (await CSharpScript.EvaluateAsync(input)).ToString();
        }
    }
}
