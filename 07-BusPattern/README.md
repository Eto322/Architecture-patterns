# Event Bus

Event Bus is a Python implementation of the Event Bus pattern. It provides a decoupled communication mechanism between publishers and subscribers through a central event bus.

## Pattern Description

The Event Bus pattern acts as a mediator between components by allowing them to communicate indirectly through events. Publishers send events to the event bus, and the event bus routes those events to the interested subscribers.

In this implementation, the `EventBus` class represents the central event bus. Components can subscribe to specific event types using the `subscribe` method, unsubscribe using the `unsubscribe` method, and publish events using the `publish` method.

## Getting Started

### Prerequisites

- Python 3.x

### Installation

1. Clone the repository:
   ```shell
   git clone <repository-url>
   ```

2. Navigate to the project directory:
   ```shell
   cd 07-BusPattern
   ```


## Running the Tests

To run the unit tests:

1. Open a terminal or command prompt.

2. Navigate to the project directory.

3. Run the following command:
   ```shell
   python -m unittest test_event_bus.py
   ```

The test results will be displayed, indicating whether the tests passed or failed.
