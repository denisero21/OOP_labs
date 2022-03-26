using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Account : IAccount
    {
        public string Id { get; set; }
        public string AccountNumber { get; set; }
        public string UserID { get; set; }
        public string BankName{get;set;}
        public double Sum { get; set; }
        public double SavingSum = 0;
        public double AccumulationSum = 0;
        public bool Active = true;

        Transfer ATransfer = new Transfer();

        public Account(string userId, double sum, string bankname)
        {
            this.Id = Guid.NewGuid().ToString();
            this.AccountNumber = Guid.NewGuid().ToString();
            this.AccountNumber = this.AccountNumber.Substring(0, 8);
            this.UserID = userId;
            this.Sum = sum;
            this.BankName = bankname;
        }

        public Account GetAccount(string id, string accNum, string userId, double sum, string bankname)
        {
            this.Id = id;
            this.AccountNumber = accNum;
            this.UserID = userId;
            this.Sum = sum;
            this.BankName = bankname;

            return this;
        }

        public void SavingMoney(double sum, double percent)
        {
            if (sum <= this.Sum && Active) this.SavingSum = sum;
            else return;
        }

        public void CashOut(double sum)
        {
            if (sum <= this.Sum && Active) this.Sum -= sum;
            else return;
        }

        public void Transfer(String numberSender, string numberOfRecepient, double sum)
        {
            /*//readfile or uploading from db
            List<Account> Accounts = new List<Account>();
            Account This = null;
            string idRecepient = null;

            foreach (Account i in Accounts)
            {
                if (numberSender == i.AccountNumber)
                {
                    This = i;
                }
            }
            foreach (Account i in Accounts)
            {
                if (numberOfRecepient == i.AccountNumber)
                {
                    idRecepient = i.Id;
                }
            }
            ATransfer.TransferTo(this.Id, idRecepient, sum);*/
        }

        public void Accumulation(double sum, double percent)
        {
            if (sum <= this.Sum && Active) this.AccumulationSum = sum + (sum * percent);
            else return;
        }

        public void BlockAccount()
        {
            //deleting object from db
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
