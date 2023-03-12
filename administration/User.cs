using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administration
{

    internal class User
    {
        public string mail { get; set; }

        public string login { get; set; }

        public string password { get; set; }

        public role r { get; set; }
        public User(string mail, string login, string password, role r)
        {
            this.mail = mail;
            this.login = login;
            this.password = password;
            this.r = r;
        }

    }
    internal class Mail 
    {
        
        public string login { set; get; }

        public string text { get; set; }   
        public Mail (string login, string text)
        {
            this.login = login;
            this.text = text;  
        }
    }
}
