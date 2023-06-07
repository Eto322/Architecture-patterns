# Pipe-Filter Pattern Example

This project demonstrates the implementation of the Pipe-Filter pattern using C# and .NET.

The Pipe-Filter pattern is a structural design pattern that allows you to process data through a series of filters, where each filter performs a specific transformation or validation on the data. The output of one filter serves as the input to the next filter, forming a pipeline.

## Project Structure

The project consists of the following files:

- `Program.cs`: The entry point of the application where the Pipe-Filter pipeline is constructed and executed.
- `UpperCaseFilter.cs`: Implements the `IFilter` interface and performs the transformation to convert input to uppercase.
- `ReverseFilter.cs`: Implements the `IFilter` interface and performs the transformation to reverse the input string.
- `PipeFilter.Tests` folder: Contains unit tests for the filters and the pipeline.

## Getting Started

To run the project, follow these steps:

1. Clone the repository:

   ```bash
   git clone <repository-url>
   ```

2. Navigate to the project directory:

   ```bash
   cd 04-Pipe-Filter
   ```

3. Build the project:

   ```bash
   dotnet build
   ```

4. Run the project:

   ```bash
   dotnet run
   ```

   The program will execute the Pipe-Filter pipeline on the input string and display the transformed output.

## Running the Tests

The project includes unit tests to verify the functionality of the filters and the pipeline. To run the tests, follow these steps:

1. Navigate to the test project directory:

   ```bash
   cd Test
   ```

2. Run the tests:

   ```bash
   dotnet test
   ```

   The tests will execute, and the test results will be displayed in the console.
