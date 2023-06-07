import unittest
import threading
import socket

from P2P import P2PNode

class P2PTestCase(unittest.TestCase):
    def test_p2p_communication(self):
        host = 'localhost'
        port = 54321

        def run_p2p_node():
            node = P2PNode(host, port)
            node.start()

        p2p_thread = threading.Thread(target=run_p2p_node)
        p2p_thread.start()

        def send_message():
            client_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
            client_socket.connect((host, port))
            message = "Hello, P2P Node!"
            client_socket.send(message.encode())
            response = client_socket.recv(1024).decode()
            self.assertEqual(response, "Response from P2P Node")
            client_socket.close()

        send_thread = threading.Thread(target=send_message)
        send_thread.start()
        send_thread.join()

if __name__ == '__main__':
    unittest.main()
