using System;
using System.Collections.Generic;
using System.Data;


namespace lab1
{
    public class Manager : Operator
    {
        Database db = Program.database;
        public void ConfirmCredit(string login)
        {
            /*Client New = db.FindByLogin
            
            return New;*/
        }

        public void DeclineCredit(string number)
        {
            db.RemoveCredit(number);
        }

        public void ConfirmInstallment(string id)
        {
            //readfile
            List<Installment> installments = new List<Installment>();//for no problem in terminal
            foreach (Installment i in installments)
            {
                if (id == i.Id)
                {
                    i.Approved = true;
                }
            }
        }

        public void DeclineInstallment(string number)
        {
            db.RemoveInstallment(number);
        }

        public void DeclineOperation() { }
    }
}
