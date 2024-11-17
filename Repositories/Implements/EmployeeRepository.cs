using Repository.Helpers;
using Repository.Models;
using Repository.Repositories.Abstracts;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Implements;

class EmployeeRepository : IEmployeeRepository
{


    public bool Create(Employee data)
    {
        return SqlHelper.Exec($"Insert into Employee Values(N'{data.Name}',N'{data.Surname}',N'{data.Position}','{data.Salary}')");


    }

    public bool Delete(int id)
    {

        return SqlHelper.Exec($"Delete Employee where Id={id}");
        
    }

    public List<Employee> GetAll()
    {
        List<Employee> list = [];
        var dt = SqlHelper.Read("Select * FROM Employee");
        foreach (DataRow item in dt.Rows)
        {
            list.Add(new Employee
            {
                Id = Convert.ToInt32(item[0]),
                Name = item[1].ToString(),
                Surname = item[2].ToString(),
                Position = item[3].ToString(),
                Salary = item[4].ToString()
                



            }
            );
        }
        return list;

    }

    public Employee? GetById(int id)
    {
        var dt = SqlHelper.Read("Select * from Employee where Id =" + id);
        if (dt.Rows.Count > 0)
        {
            return new Employee
            {

                Id = Convert.ToInt32(dt.Rows[0]),
                Name = dt.Rows[1].ToString(),
                Surname = dt.Rows[2].ToString(),
                Position = dt.Rows[3].ToString(),
                Salary = dt.Rows[4].ToString()
                


            };
            
        }
        return null;
    }

    public bool Update(int id, Employee data)
    {
        return SqlHelper.Exec($"Update Employee Set Name=N'{data.Name}',Surname=N'{data.Surname}',Position=N'{data.Position}',Salary='{data.Salary}' where Id="+id);
    }
}