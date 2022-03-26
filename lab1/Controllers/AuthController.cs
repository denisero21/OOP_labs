using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class AuthController
    {
        Database db = Program.database;

        public AuthController() { }

        public Client Auth(string login, string password)
        {
            return db.FindByLoginAndPassword(login, password);
        }
    }
}
