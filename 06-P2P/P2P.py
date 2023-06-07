import socket
import threading

class P2PNode:
    def __init__(self, host, port):
        self.host = host
        self.port = port
        self.socket = None

    def start(self):
        with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as self.socket:
            self.socket.bind((self.host, self.port))
            self.socket.listen(5)
            print(f"P2P Node started at {self.host}:{self.port}")

            accept_thread = threading.Thread(target=self.accept_connections)
            accept_thread.start()
            accept_thread.join()

    def accept_connections(self):
        while True:
            client_socket, client_address = self.socket.accept()
            print(f"Accepted connection from {client_address[0]}:{client_address[1]}")
            client_thread = threading.Thread(target=self.handle_connection, args=(client_socket,))
            client_thread.start()

    def handle_connection(self, client_socket):
        with client_socket:
            while True:
                data = client_socket.recv(1024).decode()
                if not data:
                    break
                print(f"Received data: {data}")
                response = "Response from P2P Node"
                client_socket.send(response.encode())
