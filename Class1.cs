using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace profile_management_system
{
    internal class Class1
    {
        private string username;
        private  string Password;
        private  string email;
            public void set(string username,string Password,string email)
        {
           if (!string.IsNullOrWhiteSpace(username))
            {
                this.username = username;   
            }
            else
            {
                Console.WriteLine("username cannot be empty");
            }
            if (Password.Length >= 6)
            {
                this.Password = Password;
            }
            else
            {
                Console.WriteLine("Password must be 6 character long");
            }
            if (email.Contains("@"))
            {
                this.email=email;
            }
            else
            {
                Console.WriteLine("email is not valid");
            }
        }
        public void get()
        {
            Console.WriteLine ("username:" +username);
            Console.WriteLine ("Password:"+Password);
            Console.WriteLine("email:" +email);
        }
    }
}
