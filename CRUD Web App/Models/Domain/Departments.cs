using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_Web_App.Models.Domain
{
    public class Departments
    {
        public Guid Id { get; set; }
        public string DepartmentName { get; set; }
        //public IList<Users> Users { get; set; }

    }
}
