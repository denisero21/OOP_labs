using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1.Controllers
{
    public class AnotherSpecialistController
    {
        Database db = Program.database;
        public AnotherSpecialist ASpecialist = null;

        public AnotherSpecialist GetSpecialist(string login)
        {
            ASpecialist = db.GetAnotherSpecialist(login);
            return ASpecialist;
        }

        public void Transfer(string nameSender, string nameRec, string idSen, string idRec, double sum)
        {
            ASpecialist.TransferTo(nameSender, nameRec, idSen, idRec, sum);
        }

        public void TakeSalaryProject(double sum)
        {
            ASpecialist.TakeSalaryProject(sum);
        }
    }
}
