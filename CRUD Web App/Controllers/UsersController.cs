using CRUD_Web_App.Data;
using CRUD_Web_App.Models;
using CRUD_Web_App.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD_Web_App.Controllers
{
    public class UsersController : Controller
    {
        public UsersController(MVCDbContext MVCContext)
        {
            this.MVCContext = MVCContext;
        }

        public MVCDbContext MVCContext { get; }


        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var users = await MVCContext.Users.ToListAsync();
            return View(users);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<IActionResult> Add(AddUsersView addUsersRequest) // convertion of adduserview -> users
        {
            var user = new Users()
            {
                Name = addUsersRequest.Name,
                Email = addUsersRequest.Email,
                Salary = addUsersRequest.Salary,
                Department = addUsersRequest.Department,
            };
            
            await MVCContext.Users.AddAsync(user);
            await MVCContext.SaveChangesAsync();
            return RedirectToAction("Index");

        }
        [HttpGet]        
        public async Task<IActionResult> View(Guid id)
        {
            var user = await MVCContext.Users.FirstOrDefaultAsync(x => x.Id == id);

            if (user != null)
            {
                var ViewModel = new UpdateUser()
                {
                    Id = user.Id,
                    Name = user.Name,
                    Email = user.Email,
                    Salary = user.Salary,
                    Department = user.Department,
                };
                return await Task.Run(() => View("View", ViewModel));
            }
            return RedirectToAction("index");
        }

        [HttpPost]
        public async Task<IActionResult> View(UpdateUser model)
        {
            var user = await MVCContext.Users.FindAsync(model.Id);
            if(user != null)
            {
                user.Id = model.Id;
                user.Name = model.Name; 
                user.Email = model.Email;
                user.Salary = model.Salary;
                user.Department = model.Department;

                await MVCContext.SaveChangesAsync();
                return RedirectToAction("index");
            }
            return RedirectToAction("index");
        }

        [HttpPost]
        public async Task<IActionResult> Delete(UpdateUser model) // for del, we just need id as usual
        {
            var user = await MVCContext.Users.FindAsync(model.Id);
            if(user != null)
            {
                MVCContext.Users.Remove(user);
                await MVCContext.SaveChangesAsync();
                return RedirectToAction("View");
            }
            return RedirectToAction("Index");
        }

    }
}
