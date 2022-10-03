
namespace CRUD_Web_App.Models
{
    public class Users
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Email { get; set; }
        public long Salary { get; set; }
        public int DepartmentsId { get; set; }
        public Departments Departments { get; set; }
    }
}
