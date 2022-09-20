namespace CRUD_Web_App.Models.Domain
{
    public class Users
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long Salary { get; set; }
        // public string Department { get; set; }
        public int DepartmentID { get; set; }
        public List<Departments> Departments { get; set; } // = new List<Departments> { };

    }
}
