using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class AccountController
    {
        Database db = Program.database;
        public Account ActiveAccount = null;

        public Account GetAccount(string number)
        {
            ActiveAccount = db.GetAccount(number);
            return ActiveAccount;
        }

        public void OnSaving(double sum)
        {
            ActiveAccount.SavingMoney(sum);
        }

        public void CashOut(double sum)
        {
            ActiveAccount.CashOut(sum);
        }

        public void Transfer(string numberRecepient, double sum)
        {
            ActiveAccount.Transfer(ActiveAccount.AccountNumber, numberRecepient, sum);
        }

        public void Accumulation(double sum, double percent)
        {
            ActiveAccount.Accumulation(sum, percent);
        }

        public void Freeze()
        {
            ActiveAccount.Freeze();
        }

        public void Unfreeze()
        {
            ActiveAccount.Unfreeze();
        }

        public void Block()
        {
            ActiveAccount.BlockAccount();
        }

        public void GetNumbers(System.Windows.Forms.ComboBox box)
        {
            foreach(Account i in db.Accounts)
            {
                if (i.AccountNumber != ActiveAccount.AccountNumber) box.Items.Add(i.AccountNumber.ToString());
            }
        }
    }
}
