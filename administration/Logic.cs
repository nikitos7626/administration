using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace administration
{
    internal class Logic
    {
        public static string login_user;

        public List<User> SaveOne(string mail, string login, string password, role r)
        {
            List<User> usersFromDB = ReadAll();
            User newUser = new User(mail, login, password, r);
            usersFromDB.Add(newUser);

            string serialUsers = JsonConvert.SerializeObject(usersFromDB);
            File.WriteAllText("db.json", serialUsers);
            return usersFromDB;
        }


        public List<Mail> SaveMail(string login, string mail)
        {
            List<Mail> usersFromMail = ReadAllMail();
            Mail newMail = new Mail(login, mail);
            usersFromMail.Add(newMail);
            string serialMail = JsonConvert.SerializeObject(usersFromMail);
            File.WriteAllText("mail.json", serialMail);
            return usersFromMail;
        }
        public List<Mail> ReadAllMail()
        {
            string json = File.ReadAllText("mail.json");
            List<Mail> users = JsonConvert.DeserializeObject<List<Mail>>(json);
            return users;
        }

        public List<User> ReadAll()
        {
            string json = File.ReadAllText("db.json");
            List<User> users = JsonConvert.DeserializeObject<List<User>>(json);
            return users;
        }

        public role Authorize(string login, string password)
        {
            List<User> users = ReadAll();
            foreach (var item in users)
            {
                if (item.login == login)
                {
                    if (item.password == password)
                    {

                        return item.r;
                    }
                    else
                    {
                        MessageBox.Show("Неправильный пароль");
                    }

                }

            }
            return role.nonUser;
        }
        public string GetNames()
        {
           string res = "Вывод всех логинов : ";
            List<User> users= ReadAll();
            foreach (var item in users)
            {
                res = res+ item.login + " \n " ;
            }
            return res;
        }
        

        public string GetLogin()
        {
            string res = " ";
            List<User> users= ReadAll();
            foreach(var item in users)
            {
                res = res+ item.login;
            }
            return res;
        }
        public List<Mail> GetMail()
        {
            List<Mail> mails_user = new List<Mail>();
            string res = " ";
            List<Mail> users = ReadAllMail();
            foreach (var item in users)
            {
                if (item.login == login_user)
                {
                    mails_user.Add(item); 
                }
                
            }
            return mails_user;
                
        }
        public string GetAllMail()
        {
            List<Mail> mails_mail = new List<Mail>();
            string res = " Вывод всех писем:  \n";
            List<Mail> users = ReadAllMail();
            foreach (var item in users)
            {
                res = res + item.text + "\n" ;
            }
            return res;
        }
        
       
        


    }
}
