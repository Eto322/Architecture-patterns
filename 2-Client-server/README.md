# Client-Server Pattern Example

This is an example project demonstrating the implementation of a simple client-server pattern using C# and .NET.

## Description

The project implements a client-server pattern within a single application. The application acts as both the server and the client, allowing communication between different instances of the application.

The server listens for incoming connections from other instances of the application acting as clients. The client connects to the server and sends messages.

The communication is based on the TCP/IP protocol. The server starts a TCP listener, accepts incoming client connections, and spawns a separate thread to handle each client connection. The server receives messages from clients and displays them in the console.

The client connects to the server using its IP address and port number. It sends messages to the server through a TCP client connection.

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
   cd ClientServerPattern
   ```

### Running the Project

1. Open a terminal or command prompt.

2. Start the server and the client by running the following command:

   ```bash
   dotnet run 
   ```

   The application will start and display a message indicating that the server is waiting for connections.

3. The server and client instances within the application will communicate with each other. The server will display any messages received from the clients in the console.

4. To stop the application, press `Ctrl + C` in the terminal or command prompt where the application is running.

### Running the Tests

1. Open a terminal or command prompt.

2. Navigate to the project directory:

   ```bash
   cd ClientServerPattern.Tests
   ```

3. Run the tests by executing the following command:

   ```bash
   dotnet test
   ```

   The unit tests will execute and verify the functionality of the client-server communication.
