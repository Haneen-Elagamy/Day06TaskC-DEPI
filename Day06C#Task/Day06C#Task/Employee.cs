using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day06C_Task
{
    internal struct Employee
    {
        private int EmpId;
        private string Name;
        private decimal salary;

        //Constructor
        public Employee(int EmpId, string Name, decimal Salary)
        {
            this.EmpId = EmpId;
            this.Name = Name;
            this.salary = Salary;
        }

        //GetName method
        public string GetName()
        {
            return Name;
        }

        //SetName method
        public void SetName(string value)
        {
            Name = value.Length <= 10 ? value : value.Substring(0, 10);
        }

        //property
        public decimal Salary
        {
            get
            { 
                return salary;
            }
            set
            {
                salary = value < 10000 ? 10000 : value;
            }

        }

        //Q3
        //Question: Why is encapsulation critical in software design?

        /*1-Data Security:
          It protects sensitive data by restricting direct access to class or struct members. 
           This ensures that only authorized methods can modify the data.

       2-Maintainability:
         Encapsulation allows you to change the implementation of a class without affecting external code.
         This makes maintenance and updates easier.

        3-Control:
        By exposing controlled access through methods and properties, you can enforce rules
         (e.g., validation) when getting or setting values.

        4-Reusability:
        Encapsulation creates self-contained units of functionality, making it easier to reuse and share code across the project.

       5-Abstraction:
       It hides the internal implementation details from the outside, allowing users to interact with an object
        without knowing how it works internally.

      6-Bug Prevention:
       By restricting direct access, you reduce the chances of unintended or invalid changes to the data, minimizing bugs.*/
    }
}
