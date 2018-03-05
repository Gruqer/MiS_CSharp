using System;

namespace MiŚ.Core.User
{
    public class User
    {
        protected string username;

        protected string password;

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
            //TODO sprawdzić uprawnienia w bazie danych
        }
    }
}
