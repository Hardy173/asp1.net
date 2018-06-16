using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore1.Models
{
    public class EmployeeView
    {
        public int ID {get; set;}
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Patronymic { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public string Experience { get; set; }
        public string DOB { get; set; }
    }
}
