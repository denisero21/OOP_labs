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
            if (db.FindByLoginAndPassword(login, password).UserID == "") return null;
            else return db.FindByLoginAndPassword(login, password);
        }

        public Operator AuthOp(string login, string password)
        {
            if (db.GetOperator(login, password).UserID == "") return null;
            else return db.GetOperator(login, password);
        }

        public Manager AuthMan(string login, string password)
        {
            if (db.GetManager(login, password).UserID == "") return null;
            else return db.GetManager(login, password);
        }

        public Admin AuthAdm(string login, string password)
        {
            if (db.GetAdmin(login, password).UserID == "") return null;
            else return db.GetAdmin(login, password);
        }

        public AnotherSpecialist AuthAnSp(string login, string password)
        {
            if (db.GetAnotherSpecialist(login, password).UserID == "") return null;
            else return db.GetAnotherSpecialist(login, password);
        }
    }
}
