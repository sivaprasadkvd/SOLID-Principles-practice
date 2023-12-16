using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// liskov Substitution Principle states that we can able to use any derived class instead of base class without modification.

// all base class methods must be applicable for the derived class.

namespace solid_principles_practice
{
    internal class soLid3
    {
        public class Employee  //base class
        {
            public virtual int CalculateSalary()
            {
                return 10000;
            }
            public virtual int CalculateBonus()
            {
                return 1000;
            }
        }

        public class PermantEmployee : Employee  // derived1
        {
            public override int CalculateSalary()
            {
                return 300000;
            }
        }

        public class ContractualEmployee : Employee  // derived2
        {
            public override int CalculateSalary()
            {
                return 200000;
            }

            public override int CalculateBonus()
            {
                throw new NotImplementedException();
            }
        }

        static void Main(string[] args)
        {
            Employee emp = new Employee();

            PermantEmployee pemp = new PermantEmployee();

            ContractualEmployee cemp = new ContractualEmployee();


            Console.WriteLine(emp.CalculateSalary());
            Console.WriteLine(emp.CalculateBonus());
           

            Console.WriteLine(pemp.CalculateSalary());
            Console.WriteLine(pemp.CalculateBonus());

            Console.WriteLine(cemp.CalculateSalary());
            Console.WriteLine(cemp.CalculateBonus());
        }
    }
}
