
using System.ComponentModel.DataAnnotations;

namespace FirstAPI
{
    public class Employee
    {
        [Key]
        public int EmpID { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }
    }
}
