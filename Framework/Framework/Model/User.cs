

namespace Framework.Model
{
    class User
    {
        private string _login;
        public string Login
        {
            get
            {
                return _login;
            }
            set
            {
                _login = value;
            }
        }

        private string _password;
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        public User(string login, string password)
        {
            _login = login;
            _password = password;
        }

        public override string ToString()
        {
            return "User{" +
                    "login='" + _login + '\'' +
                    ", password='" + _password + '\'' +
                    '}';
        }
    }
}
