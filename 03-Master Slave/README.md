# Master-Slave Pattern Example

This is an example project demonstrating the implementation of a simple master-slave pattern using C# and .NET.

## Description

The project implements a master-slave pattern within a single application. The application acts as both the master and the slave, allowing distributed task execution.

The master node distributes task data among multiple slave nodes. Each slave node processes the assigned task data and returns the results to the master node. The master node then collects and verifies the task results.



## Getting Started

These instructions will help you set up and run the project on your local machine.

### Prerequisites

- .NET SDK installed. You can download it from the official .NET website (https://dotnet.microsoft.com/download).

### Installation

1. Clone the repository:

   ```bash
   git clone <repository-url>
   ```

2. Navigate to the project directory:

   ```bash
   cd 03-Master Slave
   ```

### Running the Project

1. Open a terminal or command prompt.

2. Start the application by running the following command:

   ```bash
   dotnet run
   ```

   The application will start and execute the master-slave pattern logic. The output will be displayed in the console.



### Running the Tests

1. Open a terminal or command prompt.

2. Navigate to the project directory:

   ```bash
   cd Test
   ```

3. Run the tests by executing the following command:

   ```bash
   dotnet test
   ```

   The unit tests will execute and verify the functionality of the master-slave pattern implementation.
