using Repository.Models;
using Repository.Repositories.Abstracts;
using Repository.Repositories.Implements;

namespace Repository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IEmployeeRepository repo = new EmployeeRepository();
            /* repo.Create(new Employee
             {

                 Name = "Mikayil",
                 Surname = "Ismayilov",
                 Position = "Photographer",
                 Salary = "666.66"

             });*/
            repo.GetAll().ForEach(x => Console.WriteLine(x.Name +' '+ x.Surname ));
            //repo.Delete(2);
            /*repo.Update(5, new Employee
                {
                 Name="Mehmet",
                 Surname="Ismayilov",
                 Position="Director",
                 Salary ="1000.00"

            } );*/
        }
    }
}
