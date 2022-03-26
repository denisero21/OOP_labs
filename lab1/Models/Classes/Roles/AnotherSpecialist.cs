using System;
using System.Data;


namespace lab1
{
    public class AnotherSpecialist : User
    {
        Database db = Program.database;
        SalaryProject salprj = null;

        public AnotherSpecialist(string login, string password)
        {
            this.UserID = Guid.NewGuid().ToString();
            this.Login = login;
            this.Password = password;
        }

        public AnotherSpecialist GetAnotherSpecialist(string id, string login, string password)
        {
            this.UserID = id;
            this.Login = login;
            this.Password = password;
            return this;
        }

        public void TransferTo(string companySender,string companyRecepient,string numberSender, string numberOfRecepient,double sum)
        {
            foreach(Company i in db.Companies)
            {
                if(companySender == i.Name)
                {
                    foreach(Company j in db.Companies)
                    {
                        if(companyRecepient == j.Name) i.Accounts[i.Accounts.BinarySearch(db.GetAccount(numberSender))].Transfer(numberSender, numberOfRecepient, sum);
                    }
                }
            }
        }

        public void TakeSalaryProject(double sum)//add bank and logs
        {
            salprj = new SalaryProject(this.UserID, sum);
            db.AddSalaryProect(salprj.Id, salprj.SalaryProjectNumber, salprj.UserID, salprj.Sum, salprj.Approved, salprj.Cancelled);
        }
    }
}
