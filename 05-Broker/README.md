# Broker

Broker is a C# implementation of the Broker architectural pattern. It provides a decoupled communication mechanism between publishers (senders) and subscribers (receivers) by using a broker entity to route messages.

## Pattern Description

The Broker pattern acts as an intermediary component that allows publishers and subscribers to communicate without being directly aware of each other. Publishers send messages to the broker, and the broker routes those messages to the appropriate subscribers based on their registered interests.

In this implementation, the `Broker` class represents the broker entity, and the `Client` class represents the subscribers. Publishers can send messages to the broker, and the broker forwards those messages to the subscribed clients.

## Getting Started

### Prerequisites

- .NET SDK installed. You can download it from the official .NET website (https://dotnet.microsoft.com/download).

### Installation

1. Clone the repository:
   ```shell
   git clone <repository-url>
   ```

2. Navigate to the project folder:
   ```shell
   cd 05-Broker
   ```

### Usage

1. Run the project:
   ```shell
   dotnet run
   ```



### Running the Tests

To run the unit tests:

1. Navigate to the `Tests` folder:
   ```shell
   cd Tests
   ```

2. Run the tests:
   ```shell
   dotnet test
   ```

