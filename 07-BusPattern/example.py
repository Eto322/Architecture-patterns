from event_bus import EventBus


def on_event(data):
    print(f"Received event with data: {data}")

def on_another_event(data):
    print(f"Received another event with data: {data}")


event_bus = EventBus()


event_bus.subscribe("event_type1", on_event)
event_bus.subscribe("event_type2", on_another_event)


event_bus.publish("event_type1", "Hello, World!")
event_bus.publish("event_type2", 42)

event_bus.unsubscribe("event_type1", on_event)


event_bus.publish("event_type1", "This event won't be received")
