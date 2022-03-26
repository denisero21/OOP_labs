using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public abstract class User
    {
        public string UserID { get; set; }
        public string Login { get; set; }
        protected string Password { get; set; }
        protected string Name { get; set; }
        protected string Surname { get; set; }
        protected string Patronymic { get; set; }

    }
}
