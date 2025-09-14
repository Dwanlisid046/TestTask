using System;

namespace TestTask.Entity
{
    public class Employee
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string StatusName { get; set; }
        public string DepartmentName { get; set; }
        public string PositionName { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime? FireDate { get; set; }

        public string FullName => $"{LastName} {FirstName[0]}. {MiddleName[0]}.";
        public bool IsFired => FireDate.HasValue;
    }
}
