namespace Numbers
{
    public class Validator
    {
        // This method should return true if the input is a valid integer, otherwise false
        public bool IsValidInteger(string input)
        {
            // Check if the input is null or empty
            if (string.IsNullOrEmpty(input))
            {
                return false;
            }

            // Check if the input is a valid integer
            return int.TryParse(input, out _);
        }

    }
}