using Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Abstracts
{
    interface IEmployeeRepository
    {
        List<Employee> GetAll();
        Employee? GetById(int id);
        bool Create(Employee data);
        bool Delete(int id);
        bool Update(int id,Employee data );
    }
}
