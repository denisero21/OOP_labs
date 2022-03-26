using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Transfer : ITransfer
    {
        Database db = Program.database;
        int Sum { get; set; }

        public Transfer() 
        {
            
        }

        public void TransferTo(string numberSender, string numberOfRecepient, double sum)
        {
            foreach (Account i in db.Accounts)
            {
                if (numberSender == i.AccountNumber)
                {
                    foreach (Account j in db.Accounts)
                    {
                        if (numberOfRecepient == j.AccountNumber)
                        {
                            if (i.Sum >= sum)
                            {
                                i.Sum -= sum;
                                j.Sum += sum;
                            }
                        }
                    }
                }
            }
        }
    }
}
