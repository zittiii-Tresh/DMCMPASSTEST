using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MealPass.Core
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public required string FirstName { get; set; }
        public required string MiddleName { get; set; }
        public required string LastName { get; set; }
        public required string NameExtension { get; set; }
        public required string Gender { get; set; }
        public DateTime Birthdate { get; set; }
        public required string ContactNo { get; set; }
        public required string Username { get; set; }
        public string Password { get; set; }
        public int RoleID { get; set; }
        public int CivilStatusID { get; set; }
        public int EmploymentStatus { get; set; }
        public int FailedAttempts { get; set; }
        public int IsLocked { get; set; }
        public Employee() { }
    }
}
