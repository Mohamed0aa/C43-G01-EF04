using Demo.Data;
using Demo.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Demo.Data_Additions
{
    internal static class Seeding
    {
        public static void Seed(TEST_DbContext seed)
        {
            if (!seed.Departments.Any())//Cheack if Department is Empty or not
            {
                var departmentsDate = File.ReadAllText($"{Directory.GetCurrentDirectory()}/departments.json");
                var departments = JsonSerializer.Deserialize<List<Department>>(departmentsDate);


                seed.Departments.AddRange(departments);
                seed.SaveChanges();
            }


            if (!seed.Employees.Any())//Cheack if Department is Empty or not
            {
                var employeesDate = File.ReadAllText($"{Directory.GetCurrentDirectory()}/employees.json");
                var employees = JsonSerializer.Deserialize<List<Employee>>(employeesDate);


                seed.Employees.AddRange(employees);
                seed.SaveChanges();
            }
        }
    }
}
