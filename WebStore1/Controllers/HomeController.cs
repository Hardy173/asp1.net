using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore1.Models;

namespace WebStore1.Properties.Controllers
{
    public class HomeController : Controller
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
            //List<EmployeeView> res = (from u in _employees join n in Id on u.ID equals n select u).ToList();





            //return View(_employees.Find(item => item.ID == Id));

            //return View(_employees.Find(x => x.ID == Id));
        }
    }
}