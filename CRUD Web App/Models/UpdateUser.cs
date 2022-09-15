namespace CRUD_Web_App.Models
{
    public class UpdateUser
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public long Salary { get; set; }
        public string Department { get; set; }
    }
}
