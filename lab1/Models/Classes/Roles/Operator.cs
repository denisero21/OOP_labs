using System;
using System.Collections.Generic;
using System.IO;

namespace lab1
{
    public class Operator : User
    {
        Database db = Program.database;
        List<string> logs = new List<string>(); 

        public Operator() { }
        public Operator(string login, string password)
        {
            this.UserID = Guid.NewGuid().ToString();
            this.Login = login;
            this.Password = password;
        }

        public Operator GetOperator(string id, string login, string password)
        {
            this.UserID = id;
            this.Login = login;
            this.Password = password;

            return this;
        }

        public void GetStatistics()//add journal
        {
            string[] s = File.ReadAllLines("test.txt");
            foreach (string i in s)
            {
                logs.Add(i);
            }
        }

        public void ConfirmSalaryProject(string salprjNumber)
        {
            foreach(SalaryProject i in db.SalaryProjects)
            {
                if(salprjNumber == i.SalaryProjectNumber)
                {
                    i.Approved = true;
                }
            }
        }

        public void DeclineSalaryProject(string number)
        {
            db.RemoveSalaryProject(number);
        }
    }
}
