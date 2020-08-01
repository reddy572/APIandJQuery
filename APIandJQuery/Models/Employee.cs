using System.ComponentModel.DataAnnotations;

namespace APIandJQuery.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpDesignation { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}