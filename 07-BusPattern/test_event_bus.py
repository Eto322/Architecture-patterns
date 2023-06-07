import unittest
from event_bus import EventBus

class TestEventBus(unittest.TestCase):
    def test_publish_single_subscriber(self):
        # Arrange
        event_bus = EventBus()
        data = "Test data"
        received_data = None

        def callback(received):
            nonlocal received_data
            received_data = received

        event_bus.subscribe("event_type", callback)

        # Act
        event_bus.publish("event_type", data)

        # Assert
        self.assertEqual(received_data, data)

    def test_publish_multiple_subscribers(self):
        # Arrange
        event_bus = EventBus()
        data = "Test data"
        received_data = []

        def callback1(received):
            received_data.append(received)

        def callback2(received):
            received_data.append(received)

        event_bus.subscribe("event_type", callback1)
        event_bus.subscribe("event_type", callback2)

        # Act
        event_bus.publish("event_type", data)

        # Assert
        self.assertEqual(received_data, [data, data])

if __name__ == '__main__':
    unittest.main()
