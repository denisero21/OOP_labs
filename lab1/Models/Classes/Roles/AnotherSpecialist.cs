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

        public void TransferToCompany(string companyName, string companyRecepient,double sum)
        {
            /*Company New = null;
            DataRow[] row = database.tableSet.Data.Tables["Companies"].Select($"Name = '{companyName}'");
            foreach (DataRow i in row)
            {
                if (row.Length != 0)
                {
                    New.CreateCompany(
                        Convert.ToString(row[0]["Type"]),
                        Convert.ToString(row[0]["Name"]),
                        Convert.ToString(row[0]["PAN"]),
                        Convert.ToString(row[0]["BIC"]),
                        Convert.ToString(row[0]["Adress"])
                        );
                }
            }
            New.Transfer(idSender, idOfRecepient, sum);*/
        }

        public void TakeSalaryProject(double sum)//add bank and logs
        {
            salprj = new SalaryProject(this.UserID, sum);
            db.AddSalaryProect(salprj.Id, salprj.SalaryProjectNumber, salprj.UserID, salprj.Sum, salprj.Approved, salprj.Cancelled);
        }
    }
}
