using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program.Part_01.Q4
{
    //Question 4)   
    //a) Create a base class named Employee with method That Work as it prints "Employee is working".
    //
    //b) Create a derived class named Manager that overrides the Work method to print
    //   "Manager is managing". 
    //** Ensure that the Manager class also calls the Work method of the Employee class within
    //its Overridden method.
    internal class Manager : Employee
    {
        public override string Work()
        {
            
            return $"{base.Work()}\nManager is managing";
        }
    }
}
