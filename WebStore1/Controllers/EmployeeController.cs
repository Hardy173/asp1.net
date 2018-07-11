using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore1.Infrastructure.Interfaces;
using WebStore1.Models;

namespace WebStore1.Controllers
{
    [Route("users")]
    public class EmployeeController : Controller
    {
        private readonly IEmployeesData _employeesData;
        public EmployeeController(IEmployeesData employeesData)
        {
            _employeesData = employeesData;
        }

        public IActionResult Index()
        {
            return View(_employeesData.GetAll());
        }
        [Route("{id}")]

        public IActionResult Details(int id)
        {
            var selection = _employeesData.GetById(id);
            return View(selection);

        }

        [Route("edit/{id?}")]

        public IActionResult Edit(int? id)
        {
            EmployeeView model;
            if (id.HasValue)
            {
                model = _employeesData.GetById(id.Value);
                if (ReferenceEquals(model, null))
                    return NotFound();// возвращаем результат 404 Not Found
            }
            else
            {
                model = new EmployeeView();
            }
            return View(model);
        }
        [HttpPost]
        [Route("edit/{id?}")]

        public IActionResult Edit(EmployeeView model)
        {
            if (model.ID > 0)
            {
                var dbItem = _employeesData.GetById(model.ID);
                if (ReferenceEquals(dbItem, null))
                    return NotFound();// возвращаем результат 404 Not Found
                
                dbItem.FirstName = model.FirstName;
                dbItem.SurName = model.SurName;
                dbItem.Patronymic = model.Patronymic;
                dbItem.Age = model.Age;
                dbItem.City = dbItem.City;
                dbItem.Experience = dbItem.Experience;
                dbItem.DOB = dbItem.DOB;
                
            }
            else
            {
                if (ModelState.IsValid)
                {
                    _employeesData.AddNew(model);
                }
            }

            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
        [Route("delete/{id}")]

        public IActionResult Delete(int id)
        {
            _employeesData.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }


}