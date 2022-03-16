using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Installment: ICreditInstallment
    {
        double Sum;
        double Percent;
        double TotalSum;
        public bool Approved;
        public bool Cancelled;

        Installment() { }
    }
}
