import unittest
from unittest.mock import patch
from io import StringIO
from controller import create_user

class ControllerTestCase(unittest.TestCase):
    @patch('builtins.input', side_effect=['JohnDoe', 'johndoe@example.com'])
    def test_create_user(self, mock_input):
        expected_output = "User Details:\nUsername: JohnDoe, Email: johndoe@example.com\n"

       
        captured_output = StringIO()
        with patch('sys.stdout', new=captured_output):
            create_user()

        
        actual_output = captured_output.getvalue()

        self.assertEqual(actual_output, expected_output)

if __name__ == '__main__':
    unittest.main()
