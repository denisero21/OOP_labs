using System;
using System.Collections.Generic;

namespace lab1
{
    public class Bank : IBank
    {
        public string Name { get; set; }
        List<Account> Accounts = new List<Account>();
        List<Credit> Credits = new List<Credit>();
        List<Installment> Installments = new List<Installment>();
        List<Client> Clients = new List<Client>();

        public Bank(string bankName) 
        {
            this.Name = bankName;
        }
    }
}
