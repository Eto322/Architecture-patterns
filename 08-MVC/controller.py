from model import User
from view import show_user_details

def create_user():
    username = input("Enter username: ")
    email = input("Enter email: ")

    user = User(username, email)
    show_user_details(user)

if __name__ == "__main__":
    create_user()
