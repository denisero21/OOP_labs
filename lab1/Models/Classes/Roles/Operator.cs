using System;
using System.Collections.Generic;
using System.IO;

namespace lab1
{
    public class Operator : User
    {
        Database db = Program.database;
        List<string> logs = new List<string>(); 

        public void GetStatistics()//add journal
        {
            string[] s = File.ReadAllLines("test.txt");
            foreach (string i in s)
            {
                logs.Add(i);
            }
        }

        public void ConfirmSalaryProject(string id)
        {
            //readfile
            List<SalaryProject> projects = new List<SalaryProject>();//for no problem in terminal
            foreach(SalaryProject i in projects)
            {
                if(id == i.Id)
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
