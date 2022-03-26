using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Controllers
{
    public class ClientController
    {
        Database db = Program.database;
        public Client ActiveClient = null;

        public Client GetClient(string login)
        {
            ActiveClient = db.GetClient(login);
            return ActiveClient;
        }

        public void CreateAccount(double sum, string bankname, string companyname)
        {
            Account New = new Account(ActiveClient.UserID, sum, bankname, companyname);
            db.AddAccount(New.Id, New.AccountNumber, ActiveClient.UserID, bankname, companyname, sum);
        }

        public void CreateCredit(double sum, string bankname, int months)
        {
            Credit New = new Credit(ActiveClient.UserID, bankname, months, sum);
            db.AddCredit(New.Id, New.CreditNumber, ActiveClient.UserID, months, sum, New.Percent, bankname);
        }

        public void CreateInstallment(double sum, string bankname, int months)
        {
            Installment New = new Installment(ActiveClient.UserID, bankname, months, sum);
            db.AddInstallmet(New.Id, New.InstallmentNumber, ActiveClient.UserID, months, sum, New.Percent, bankname);
        }

        public void CreateSalaryProject(double sum)
        {
            SalaryProject New = new SalaryProject(ActiveClient.UserID, sum);
            db.AddSalaryProect(New.Id, New.SalaryProjectNumber, ActiveClient.UserID, sum);
        }
    }
}
