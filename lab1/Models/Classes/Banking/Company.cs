using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Company : ICompany
    {
        Database db = Program.database;
        Bank CBank = null;

        public string CompanyId { get; set; }
        string Type { get; set; }
        public string Name { get; set; }
        string PAN { get; set; }
        //9 digits, on russian UNP
        string BIC { get; set; }
        //9 digits
        string Adress { get; set; }


        public Company(string type, string name, string pan, string bic, string adress) 
        {
            this.CompanyId = Guid.NewGuid().ToString();
            this.Type = type;
            this.Name = name;
            this.PAN = pan;
            this.BIC = bic;
            this.Adress = adress;
        }

        public Company GetCompany(string companyId, string type, string name, string pan, string bic, string adress)
        {
            this.CompanyId = companyId;
            this.Type = type;
            this.Name = name;
            this.PAN = pan;
            this.BIC = bic;
            this.Adress = adress;

            return this;
        }

        public void Transfer(string numberSender, string numberOfRecepient, double sum)
        {
            /*Account This = null;
            string idRecepient = null;

            foreach (Account i in Accounts)
            {
                if (numberSender == i.AccountNumber)
                {
                    This = i;
                }
            }
            foreach(Account i in Accounts)
            {
                if(numberOfRecepient == i.AccountNumber)
                {
                    idRecepient = i.Id;
                }
            }
            This.Transfer(This.Id, idRecepient, sum);*/
        }

        public void CreateAccount(double sum, string bankName)
        {
            Account New = new Account(this.CompanyId, sum, bankName);
            db.AddAccount(New.Id, New.AccountNumber,New.UserID, New.BankName, New.Sum, New.Active);
        }
    }
}
