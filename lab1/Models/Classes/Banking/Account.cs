using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Account : IAccount
    {
        Database db = Program.database;
        Transfer ATransfer = new Transfer();
        public string Id { get; set; }
        public string AccountNumber { get; set; }
        public string UserID { get; set; }
        public string BankName{ get; set; }
        public string CompanyName { get; set; }
        public double Sum { get; set; }
        public double SavingSum = 0;
        public double AccumulationSum = 0;
        public bool Active = true;
        

        public Account(string userId, double sum, string bankname, string companyName = default)
        {
            this.Id = Guid.NewGuid().ToString();
            this.AccountNumber = Guid.NewGuid().ToString();
            this.AccountNumber = this.AccountNumber.Substring(0, 8);
            this.UserID = userId;
            this.Sum = sum;
            this.BankName = bankname;
            this.CompanyName = companyName;
        }

        public Account GetAccount(string id, string accNum, string userId, double sum, string bankname, string companyName = default)
        {
            this.Id = id;
            this.AccountNumber = accNum;
            this.UserID = userId;
            this.Sum = sum;
            this.BankName = bankname;
            this.CompanyName = companyName;

            return this;
        }

        public void SavingMoney(double sum)
        {
            if (sum <= this.Sum && Active) this.SavingSum = sum;
            else return;
        }

        public void CashOut(double sum)
        {
            if (sum <= this.Sum && Active) this.Sum -= sum;
            else return;
        }

        public void Transfer(string numberSender, string numberOfRecepient, double sum)
        {
            ATransfer.TransferTo(numberSender, numberOfRecepient, sum);
        }

        public void Accumulation(double sum, double percent)
        {
            if (sum <= this.Sum && Active) this.AccumulationSum = sum + (sum * 0.01*percent);
            else return;
        }

        public void BlockAccount()
        {
            db.RemoveAccount(this.AccountNumber);
        }

        public void Freeze()
        {
            this.Active = false;
        }

        public void Unfreeze()
        {
            this.Active = true;
        }
    }
}
