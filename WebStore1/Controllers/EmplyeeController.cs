using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore1.Models;

namespace WebStore1.Controllers
{
    public class EmplyeeController : Controller
    {
        private readonly List<EmployeeView> _employees = new List<EmployeeView>
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


        public IActionResult Index()
        {
            return View(_employees);
        }
        public IActionResult Details(int Id)
        {
            var selectedUsers = from EmployeeView in _employees
                                where EmployeeView.ID == Id
                                select EmployeeView;
            return View(selectedUsers);

        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Delete(int Id)
        {
            return View();
        }

        public IActionResult Update(int Id)
        {
            return View();
        }
    }
}