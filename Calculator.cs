 class Calculator
    {
        public static async Task<string> Parse(string input)
        {
            return (await CSharpScript.EvaluateAsync(input)).ToString();
            #something
        }
    }