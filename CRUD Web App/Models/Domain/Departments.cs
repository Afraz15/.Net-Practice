using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_Web_App.Models.Domain
{
    public class Departments
    {
        public Guid ID { get; set; }
        public string DepartmentName { get; set; }


        public int UsersID { get; set; }
        public Users Users { get; set; }
    }
}
