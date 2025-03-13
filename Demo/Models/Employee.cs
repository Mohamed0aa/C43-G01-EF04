using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
    internal class Employee
    {
        [Key]
        public int Id { get; set; }

        
        [Required]
        public string Name { get; set; }

        public double Salary { get; set; }

        public int Age { get; set; }

        [Length(100,200)]
        public string ? Address { get; set; }

        public int? DepartmentId { get; set; }
        public Department? department { get; set; }
        
        public Department? Manage { get; set; }

    }
}
