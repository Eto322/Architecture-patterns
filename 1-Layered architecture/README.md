# Project Name

This project is an example of a layered architecture pattern implemented in .NET.

## Overview

The project demonstrates how to structure an application using a layered architecture pattern, separating concerns into distinct layers: Presentation Layer, Business Logic Layer, and Data Access Layer.

## Project Structure

The project consists of the following folders:

- **PresentationLayer**: Contains the presentation layer of the application, including the main entry point `Program.cs`.

- **BusinessLogicLayer**: Contains the business logic layer of the application, including the `BusinessLogic.cs` class.

- **DataAccessLayer**: Contains the data access layer of the application, including the `DataAccess.cs` class.

- **Tests**: Contains unit tests for the application.

## Getting Started

To get started with the project, follow these steps:

1. Clone the repository or download the source code.

2. Open a terminal or command prompt and navigate to the project's root directory.

3. Restore the project dependencies by running the following command:
   ```shell
   dotnet restore
   ```

4. Build the solution by running the following command:
   ```shell
   dotnet build
   ```

5. To run the application, navigate to the `PresentationLayer` folder by running the following command:
   ```shell
   cd PresentationLayer
   ```

   Execute the application by running the following command:
   ```shell
   dotnet run
   ```

6. To run the unit tests, navigate to the `Tests` and select needed folder by running the following command:
   ```shell
   cd ../Tests/<path_to_test_project_folder>
   ```
  
   Execute the unit tests by running the following command:
   ```shell
   dotnet test
   ```

## Dependencies

The project has the following dependencies:

- .NET 

- xUnit.net 


