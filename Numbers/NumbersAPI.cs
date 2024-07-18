using RestSharp;

namespace Numbers
{
    // Class responsible for calling the API
    public class NumbersAPI
    {
        // Calling the API
        public string GetResult(string input)
        {
            var result = new RestClient("http://numbersapi.com/" + input + "/math?default=Not+a+good+number");

            return result.Get(new RestRequest()).Content;
        }
    }
}