using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore1.Models;

namespace WebStore1.Infrastructure.Interfaces
{
    public interface IEmployeesData
    {
       
        IEnumerable<EmployeeView> GetAll();
        
        EmployeeView GetById(int id);
        
        void AddNew(EmployeeView model);
        
        void Delete(int id);
    }
}
