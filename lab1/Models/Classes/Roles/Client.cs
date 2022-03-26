using System;
using System.Collections.Generic;

namespace lab1
{
    public class Client : User
    {
        Database db = Program.database;
        string PhoneNumber { get; set; }
        string Email { get; set; }
        string Passport { get; set; }
        string IdNumb { get; set; }
        string Country { get; set; }
        string Company { get; set; }

        List<Account> Accounts = new List<Account>();
        public List<string> Banks = new List<string>();
        List<Credit> Credits = new List<Credit>();
        List<Installment> Installments = new List<Installment>();
        SalaryProject salprj = null;

        public bool Approved;
        public bool Cancelled;

        public Client(string login, string password, string name, string surname, string patronymic, string phoneNumber, string email, string passport, string idNumb, string country, string company) 
        {
            this.UserID = Guid.NewGuid().ToString();
            this.Login = login;
            this.Password = password;
            this.Name = name;
            this.Surname = surname;
            this.Patronymic = patronymic;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Passport = passport;
            this.IdNumb = idNumb;
            this.Country = country;
            this.Company = company;
            foreach (Account i in db.Accounts) if (i.UserID == this.UserID) Accounts.Add(i);
            foreach (Credit i in db.Credits) if (i.UserID == this.UserID) Credits.Add(i);
            foreach (Installment i in db.Installments) if (i.UserID == this.UserID) Installments.Add(i);
            foreach (Bank i in db.Banks)
            {
                foreach (Account j in db.Accounts)
                {
                    if (i.Name == j.BankName && j.UserID == this.UserID) Banks.Add(i.Name);
                }
            }

        }

        public Client GetClient(string userId, string login, string password, string name, string surname, string patronymic, string phoneNumber, string email, string passport, string idNumb, string country, string company)
        {
            this.UserID = userId;
            this.Login = login;
            this.Password = password;
            this.Name = name;
            this.Surname = surname;
            this.Patronymic = patronymic;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Passport = passport;
            this.IdNumb = idNumb;
            this.Country = country;
            this.Company = company;

            foreach (Account i in db.Accounts) if (i.UserID == this.UserID) Accounts.Add(i);
            foreach (Credit i in db.Credits) if (i.UserID == this.UserID) Credits.Add(i);
            foreach (Installment i in db.Installments) if (i.UserID == this.UserID) Installments.Add(i);
            foreach (Bank i in db.Banks)
            {
                foreach (Account j in db.Accounts)
                {
                    if (i.Name == j.BankName && j.UserID == this.UserID) Banks.Add(i.Name);
                }
            }

            return this;
        }


        public void BuildAccount(double sum, string bankName)//add bank and logs
        {
            Account New = new Account(this.UserID, sum, bankName);
            Accounts.Add(New);
            db.AddAccount(New.Id, New.AccountNumber, New.UserID, New.BankName,New.CompanyName, New.Sum, New.Active);
        }

        public void RemoveAccount(string accountNumber)//add bank and logs
        {
            db.RemoveAccount(accountNumber);
        }

        public void TakeCredit(int months, double sum, string bank)//add bank and logs
        {
            Credit New = new Credit(this.UserID, bank, months, sum);
            Credits.Add(New);
            db.AddCredit(New.Id,New.CreditNumber,New.UserID, New.Month, New.Sum, New.Percent,New.Bank, New.Approved, New.Cancelled);
        }

        public void TakeInstallment(int months, double sum, string bank)//add bank and logs
        {
            Installment New = new Installment(this.UserID, bank, months, sum);
            Installments.Add(New);
            db.AddInstallmet(New.Id, New.InstallmentNumber, New.UserID, New.Month, New.Sum, New.Percent, New.Bank, New.Approved, New.Cancelled);
        }

        public void TakeSalaryProject(double sum)//add bank and logs
        {
            salprj = new SalaryProject(this.UserID, sum);
            db.AddSalaryProect(salprj.Id, salprj.SalaryProjectNumber, salprj.UserID, salprj.Sum, salprj.Approved, salprj.Cancelled);
        }

    }
}
