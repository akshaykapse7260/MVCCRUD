namespace ASPNETMVCCRUD.Models.Domain
{
    public class Employeee
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
        public DateTime DOB { get; set; }
        public long Salary { get; set; }
    }
}
