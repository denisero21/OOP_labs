using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Controllers
{
    public class OperatorController
    {
        Database db = Program.database;
        public Operator _operator = null;

        public Operator GetOperator(string login)
        {
            _operator = db.GetOperator(login);
            return _operator;
        }

        public void ConfirmSalaryProject(string number)
        {
            _operator.ConfirmSalaryProject(number);
        }

        public void DeclineSalaryProject(string number)
        {
            _operator.DeclineSalaryProject(number);
        }
    }
}
