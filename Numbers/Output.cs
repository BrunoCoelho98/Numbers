namespace Numbers
{
    // This class will be responsible for formatting and displaying the output
    public class Output
    {
        public static void DisplayResult(string input, string result, bool isValid)
        {    
            // Clear the console window
            // System.Console.Clear();

            if (isValid)
            {
                System.Console.WriteLine($"{result}.");
            }
            else
            {
                System.Console.WriteLine($"The input {input} is not a valid integer.");
            }
        }
    }
}