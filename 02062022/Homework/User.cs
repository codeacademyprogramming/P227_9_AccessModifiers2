using System;
using System.Collections.Generic;
using System.Text;

namespace Classes.Homework
{
    internal class User
    {
        public User(string username)
        {
            UserName = username;
        }
        public string Password;
        private string _userName;

        public string UserName
        {
            get
            {
                return _userName;
            }
            set
            {
                if (!String.IsNullOrWhiteSpace(value) && value.Length > 5 && value.Length < 26)
                    _userName = value;
            }
        }



    }
}
