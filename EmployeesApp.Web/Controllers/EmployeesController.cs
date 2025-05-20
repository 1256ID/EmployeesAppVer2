using EmployeesApp.Web.Models;
using EmployeesApp.Web.Services;
using EmployeesApp.Web.Views.Employees;
using Microsoft.AspNetCore.Mvc;
using System.Drawing;

namespace EmployeesApp.Web.Controllers
{
    public class EmployeesController : Controller
    {
        static EmployeeService service = new EmployeeService();

        [HttpGet("")]
        public IActionResult Index()
        {
            var model = service.GetAll();

            var vievModel = new IndexVM()
            {
                EmployeeItems = model.Select(e => new IndexVM.EmployeeItemVM()
                {
                    Name = e.Name,
                    Id = e.Id,
                    Email = e.Email,
                    ShowAsHighlighted = e.Email.StartsWith("admin")
                }).ToArray()

            };

            //foreach (var emp in model)
            //    Console.WriteLine($"{emp.Name}: {emp.Id}");

            return View(vievModel);
        }

        [HttpGet("create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(CreateVM viewModel)
        {
            if (!ModelState.IsValid)
                return View();

            var model = new Employee
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
            };

            service.Add(model);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet("details/{id}")]
        public IActionResult Details(int id)
        {
            var model = service.GetById(id);
            return View(model);
        }
    }
}
