using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Models
{
     internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime CreationDate { get; set; }

        public List<Employee>? employees { get; set; }

        public int? ManagerId { get; set; }
        public Employee? Manager { get; set; }


    }
}
