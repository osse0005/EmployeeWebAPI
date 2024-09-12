namespace EmployeeWebAPI.Models.Entities
{
    public class Employee
    {
        public int Id { get; set; }

        public required string FirstName { get; set; }

        public required string LastName { get; set; }

        public required string Email {  get; set; }

        public required string DOB { get; set; }

        public string? Gender { get; set; }

        public string? Education {  get; set; }

        public string? Company { get; set; }

        public int? Experience {  get; set; }

        public decimal? Package {  get; set; }
    }
}
