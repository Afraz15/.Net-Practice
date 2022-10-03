
namespace CRUD_Web_App.Models
{
    public class Departments
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}
