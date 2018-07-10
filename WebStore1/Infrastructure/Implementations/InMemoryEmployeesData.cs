using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore1.Infrastructure.Interfaces;
using WebStore1.Models;

namespace WebStore1.Infrastructure.Implementations
{
    /// <inheritdoc />
    /// <summary>
    /// Реализация интерфейса, хранит инфу в памяти
    /// </summary>
    public class InMemoryEmployeesData : IEmployeesData
    {
        private readonly List<EmployeeView> _employees;
        public InMemoryEmployeesData()
        {
            _employees = new List<EmployeeView>
        {
            new EmployeeView
            {
                ID = 1,
                FirstName = "Евгений",
                SurName = "Онегин",
                Patronymic = "Александрович",
                Age = 23,
                City = "New York",
                Experience = "5 years",
                DOB = "23.10.1985"
            },
            new EmployeeView
            {
                ID = 2,
                FirstName = "Тихон",
                SurName = "Кабанов",
                Patronymic = "Иванович",
                Age = 21,
                City = "Brooklyn",
                Experience = "3 years",
                DOB = "11.03.1991"
            }
        };
        }
        public IEnumerable<EmployeeView> GetAll()
        {
            return _employees;
        }
        public EmployeeView GetById(int id)
        {
            return _employees.FirstOrDefault(e => e.ID.Equals(id));
        }
        public void Commit()
        {
            // ничего не делаем
        }
        public void AddNew(EmployeeView model)
        {
            model.ID = _employees.Max(e => e.ID) + 1;
            _employees.Add(model);
        }
        public void Delete(int id)
        {
            var employee = GetById(id);
            if (employee != null)
            {
                _employees.Remove(employee);
            }
        }
    }
}
