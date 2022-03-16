using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Credit: ICreditInstallment
    {
        double Sum;
        double Percent;
        double TotalSum;
        public bool Approved;
        public bool Cancelled;
        Credit() { }
    }
}
