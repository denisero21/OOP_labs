using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Admin : Manager
    {
        public Admin() { }
        public Admin(string login, string password)
        {
            this.UserID = Guid.NewGuid().ToString();
            this.Login = login;
            this.Password = password;
        }

        public Admin GetAdmin(string id, string login, string password)
        {
            this.UserID = id;
            this.Login = login;
            this.Password = password;

            return this;
        }

        public void CheckAllLogs() 
        {
            //readfile journal
        }
        public void DeclineAllActions() 
        {

        }
    }
}
