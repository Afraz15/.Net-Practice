using CRUD_Web_App.Data;
using CRUD_Web_App.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD_Web_App.Controllers
{
    public class DepartmentController : Controller
    {
        public DepartmentController(MVCDbContext DeptMVCcontext)
        {
            this.DeptMVCcontext = DeptMVCcontext;
        }

        public MVCDbContext DeptMVCcontext { get; }

        public IActionResult Add()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CodeError()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddDepartment addDepartmentRequest)
        {
            var department = new Departments()
            {
                DepartmentName = addDepartmentRequest.DepartmentName,
            };

            if (addDepartmentRequest.DepartmentAdmin == "111")
            {
                DeptMVCcontext.Departments.Add(department);
                DeptMVCcontext.SaveChanges();
                return RedirectToAction("Add");
            }
            return RedirectToAction("Error");
        }
    }
}
