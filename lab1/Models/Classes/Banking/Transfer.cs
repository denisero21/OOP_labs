using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Transfer : ITransfer
    {
        int Sum { get; set; }

        public Transfer() 
        {
            
        }

        public void TransferTo(string idSender, string idOfRecepient, double sum)
        {
            //readfile or from db
            List<Account> Accounts = new List<Account>();
            Account This = null;

            foreach (Account i in Accounts)
            {
                if(idSender == i.Id)
                {
                    This = i;
                }
            }

            foreach (Account i in Accounts)
            {
                if (idOfRecepient == i.Id)
                {
                    if (i.Sum <= This.Sum)
                    {
                        This.Sum -= sum;
                        i.Sum += sum;
                    }
                }
            }
        }
    }
}
