# Facts About Numbers

## Description

This project is a console application written in C# that takes a user's input, validates if it is a valid integer, and then fetches a fun fact about the number from the Numbers API. The project is structured into several classes, each responsible for a specific part of the application's functionality.

## Project Structure

- **Numbers.Validator**: Contains a method to validate if the input is a valid integer.
- **Numbers.UserInput**: Responsible for getting the user's input from the console.
- **Numbers.Program**: The main entry point of the application which orchestrates the flow.
- **Numbers.Output**: Handles formatting and displaying the output to the console.
- **Numbers.NumbersAPI**: Responsible for calling the Numbers API to fetch a fact about the number.

## Classes and Methods

### Numbers.Validator

#### Methods
- **bool IsValidInteger(string input)**
  - Validates if the input is a valid integer.
  - Returns `true` if the input is a valid integer, otherwise `false`.

### Numbers.UserInput

#### Methods
- **static string GetNumber()**
  - Prompts the user to enter a number and returns the input as a string.

### Numbers.Program

#### Methods
- **static void Main(string[] args)**
  - The main entry point of the application.
  - Gets user input, validates it, fetches a fact from the API, and displays the result.

### Numbers.Output

#### Methods
- **static void DisplayResult(string input, string result, bool isValid)**
  - Displays the result to the console.
  - If the input is valid, displays the fact fetched from the API.
  - If the input is invalid, informs the user that the input is not a valid integer.

### Numbers.NumbersAPI

#### Methods
- **string GetResult(string input)**
  - Calls the Numbers API to fetch a fact about the number.
  - Returns the content of the API response.

## Usage

1. **Compile the Project**: Use your preferred C# compiler to compile the project.
2. **Run the Application**: Execute the compiled program.
3. **Input a Number**: When prompted, enter a number.
4. **View the Result**: The application will display whether the input is a valid integer and, if valid, a fun fact about the number from the Numbers API.

## Example

Enter a number:
42
42 is the answer to the ultimate question of life, the universe, and everything.


If the input is not a valid integer:

Enter a number:
abc
The input abc is not a valid integer.


## Dependencies

- **RestSharp**: A simple REST and HTTP API client for .NET, used for calling the Numbers API.

## External API

- **Numbers API**: http://numbersapi.com - Provides interesting facts about numbers.
