using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Company: ICompany
    {
        string Type;
        string Name;
        string PAN; //9 digits, on russian UNP
        string BIC; //9 digits
        string Adress;

        Company() { }
    }
}
