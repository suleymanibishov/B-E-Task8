using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_E_Task8
{
    class User : IAccount
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public User(string email,string pass)
        {
            Email = email;
            Password = pass;
        }
        public User(string email,string pass,string fullName):this(email,pass)
        {
            FullName = fullName;
        }
        public bool PasswordChecker()
        {
            bool size = false, bigLetter = false, smallLetter = false, number = false;

            if(Password.Length >= 8)
            {
                size = true;
                foreach (char ch in Password)
                {
                    if(ch >='A' && ch <= 'Z') { bigLetter = true; }
                    else if(ch >='a' && ch <= 'z') { smallLetter = true; }
                    else if(ch >='0' && ch <= '9') { number = true; }
                }
            }

            return size && bigLetter && smallLetter && number;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Full Name : {FullName}\nEmail : {Email}\nPassword : ********");
        }
    }
}
