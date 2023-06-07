# Blackboard Pattern

This project demonstrates the implementation of the Blackboard pattern in C#. The Blackboard pattern is a behavioral design pattern that allows multiple specialized modules to contribute their knowledge to solve complex problems.

## Getting Started

### Prerequisites
- .NET SDK installed. You can download it from the official .NET website (https://dotnet.microsoft.com/download).

### Installation and Usage
1. Clone the repository or download the project files.
2. Open a terminal or command prompt and navigate to the project directory.
3. Run the command `dotnet run` to execute the Blackboard pattern implementation.
4. The output will be displayed in the console.

## Blackboard Implementation
The `Blackboard` class in the `Program.cs` file represents the central component of the Blackboard pattern. It contains a `data` field and two methods:

- `GetData()`: Retrieves the current data stored in the blackboard.
- `SetData(string newData)`: Updates the data stored in the blackboard with the provided value.

The `Main` method creates an instance of `Blackboard`, sets some data using `SetData`, and then retrieves and displays it using `GetData`.

**Test Project - BlackboardPattern.Tests**

# BlackboardPattern.Tests

This project contains unit tests for the Blackboard pattern implementation in the `BlackboardPattern` project. It uses the xUnit testing framework.

## Test Cases
The `BlackboardTests.cs` file contains a single test method `GetData_ReturnsCorrectData`. It verifies that the `GetData` method of the `Blackboard` class returns the correct data after setting it using `SetData`.

