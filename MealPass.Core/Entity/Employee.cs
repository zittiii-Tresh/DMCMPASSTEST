using System;

namespace MealPass.Core.Entity
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string? FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? NameExtension { get; set; }
        public string? Gender { get; set; }
        public DateTime Birthdate { get; set; }
        public string? ContactNo { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public int RoleID { get; set; }
        public int CivilStatusID { get; set; }
        public int EmploymentStatus { get; set; }
        public int FailedAttempts { get; set; }
        public int IsLocked { get; set; }
    }
}
