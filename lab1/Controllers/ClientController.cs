using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
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
            db.AddAccount(New.Id, New.AccountNumber, ActiveClient.UserID, bankname, companyname, sum, New.SavingSum, New.AccumulationSum);
            ActiveClient.UpdateInformation();
        }

        public void CreateCredit(double sum, string bankname, int months)
        {
            Credit New = new Credit(ActiveClient.UserID, bankname, months, sum);
            db.AddCredit(New.Id, New.CreditNumber, ActiveClient.UserID, months, sum, New.Percent, bankname);
            ActiveClient.UpdateInformation();
        }

        public void CreateInstallment(double sum, string bankname, int months)
        {
            Installment New = new Installment(ActiveClient.UserID, bankname, months, sum);
            db.AddInstallmet(New.Id, New.InstallmentNumber, ActiveClient.UserID, months, sum, New.Percent, bankname);
            ActiveClient.UpdateInformation();
        }

        public void CreateSalaryProject(double sum)
        {
            SalaryProject New = new SalaryProject(ActiveClient.UserID, sum);
            db.AddSalaryProect(New.Id, New.SalaryProjectNumber, ActiveClient.UserID, sum);
            ActiveClient.UpdateInformation();
        }

        public void GetAccounts(System.Windows.Forms.ComboBox rich)
        {
            ActiveClient.UpdateInformation();
            var AccountNumber = from p in ActiveClient.Accounts select p.AccountNumber;
            foreach (var i in AccountNumber)
            {
                rich.Items.Add(i);
            }
        }

        public void GetCredits(System.Windows.Forms.RichTextBox rich)
        {
            ActiveClient.UpdateInformation();
            foreach(Credit i in ActiveClient.Credits)
            {
                rich.AppendText($"Credit number: {i.CreditNumber}\n" +
                    $"Bank: {i.Bank}\n" +
                    $"Sum: {i.Sum}\n" +
                    $"Percent: {i.Percent}\n" +
                    $"Months: {i.Month}\n");
                if (!(i.Approved) && !(i.Cancelled)) rich.AppendText("Approve: not approve\n\n");
                else if (i.Approved) rich.AppendText("Approve: approved\n\n");
                else if (i.Cancelled) rich.AppendText("Approve: declined\n\n");
            }
        }

        public void GetInstallments(System.Windows.Forms.RichTextBox rich)
        {
            ActiveClient.UpdateInformation();
            foreach (Installment i in ActiveClient.Installments)
            {
                rich.AppendText($"Installment number: {i.InstallmentNumber}\n" +
                    $"Bank: {i.Bank}\n" +
                    $"Sum: {i.Sum}\n" +
                    $"Percent: {i.Percent}\n" +
                    $"Months: {i.Month}\n");
                if ((!(i.Approved)) && (!(i.Cancelled))) rich.AppendText("Approve: not approve\n\n");
                else if (i.Approved) rich.AppendText("Approve: approved\n\n");
                else if (i.Cancelled) rich.AppendText("Approve: declined\n\n");
            }
        }

        public void GetBanks(System.Windows.Forms.ComboBox rich)
        {
            db.SetBanks(rich);
        }
    }
}
