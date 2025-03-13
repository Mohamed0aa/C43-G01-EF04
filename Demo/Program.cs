using Demo.Data;
using Demo.Data_Additions;
using Demo.Models;
namespace Demo
{
    internal class Program
    {
        static Program()
        {
            using TEST_DbContext tEST_DbContext = new TEST_DbContext();
            Seeding.Seed(tEST_DbContext);

        }
        static void Main(string[] args)
        {
            using (TEST_DbContext tEST_DbContext = new TEST_DbContext())
            {

                #region ex1 explicit loading
                var employee = tEST_DbContext.Employees.FirstOrDefault(E => E.Id == 2);

                tEST_DbContext.Entry(employee).Reference(nameof(Employee.department)).Load();
                Console.WriteLine($"{employee.Name} => {employee.department.Name}");
                #endregion


                #region eager loading

                #endregion


                #region lazy loding

                #endregion



            }
        }
    }
}
