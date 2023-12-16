using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// SRP == Single Responsibility Priciple
// a class shoud have only one responsibility

namespace solid_principles_practice
{

    //voilating SRP because the class has extra responsibility
    public class Employeedup
    {
        //own responsibily
        public int CalculateSalary()
        {
            return 10000;
        }
        //own responsibily
        public string getDepartment()
        {
            return "IT";
        }
        //extra responsibilty
        public void save()
        {
           //save employee to database
        }
    }

    public class Employee
    {
        public int CalculateSalary()
        {
            return 10000;
        }

        public string getDepartment()
        {
            return "IT";
        }

    }

    public class employeRepository
    {
        public void Save(Employee employee)
        {
            //save employee to database
        }
    }
}
