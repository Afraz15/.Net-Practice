namespace CRUD_Web_App.Models.Domain
{
    public class Users
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long Salary { get; set; }
        public Departments Departments { get; set; } = new Departments();
        /*public int DeptId { get; set; }
        public Departments Department { get; set; }
*/


    }
}
