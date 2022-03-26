using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Controllers
{
    public class ManagerController
    {
        Database db = Program.database;
        public Manager manager = null;

        public Manager GetManager(string login)
        {
            manager = db.GetManager(login);
            return manager;
        }

        public void ConfirmCredit(string number)
        {
            manager.ConfirmCredit(number);
        }

        public void DeclineCredit(string number)
        {
            manager.DeclineCredit(number);
        }

        public void ConfirmInstallment(string number)
        {
            manager.ConfirmInstallment(number);
        }

        public void DeclineInstallment(string number)
        {
            manager.DeclineInstallment(number);
        }

        public void ConfirmSalaryProject(string number)
        {
            manager.ConfirmSalaryProject(number);
        }

        public void DeclineSalaryProject(string number)
        {
            manager.DeclineSalaryProject(number);
        }
    }
}
