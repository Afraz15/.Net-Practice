using CRUD_Web_App.Data;
using CRUD_Web_App.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CRUD_Web_App.Controllers
{
    public class UserController : Controller
    {
        public class UsersController : Controller
        {
            private readonly MVCDbContext MVCContext;
            public UsersController(MVCDbContext mVCContext)
            {
                MVCContext = mVCContext;
            }

            public IActionResult Index()
            {
                return View();
            }
            public IActionResult Create()
            {
                ViewData["DepartmentsId"] = new SelectList(MVCContext.Departments, "Id", "Id");
                return View();
            }
            [HttpPost]
            public async Task<IActionResult> Create([Bind("Id,Name,Email,Salary,DepartmentsId")] Users users)
            {
                MVCContext.Add(users);
                await MVCContext.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

                ViewData["DepartmentsId"] = new SelectList(MVCContext.Departments, "Id", "Id", users.DepartmentsId);
                return View(users);
            }
        }
    }
}