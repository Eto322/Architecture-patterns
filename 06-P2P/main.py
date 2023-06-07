from P2P import P2PNode

if __name__ == "__main__":
    host = "localhost"
    port = 1234

    p2p_node = P2PNode(host, port)
    p2p_node.start()
