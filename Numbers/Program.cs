using System.Xml.XPath;

namespace Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = UserInput.GetNumber();
            Validator validator = new Validator();
            bool isValid = validator.IsValidInteger(input);
            string result = new NumbersAPI().GetResult(input);
            Output.DisplayResult(input, result, isValid);
        }
    }
}