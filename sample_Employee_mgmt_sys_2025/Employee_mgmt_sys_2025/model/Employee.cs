using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_mgmt_sys_2025.model
{
    // Employee class representing an employee in the system
    public class Employee
    {
        // data members /properties / fields
        public int EmployeeId { get; set; } // auto generated 4 digit number
        // ======= Data members /properties /========
        public int Id { get; set; } // auto generated 4 digit number
        public string FirstName { get; set; } // first name of the employee 

        public string DateTime  DateOfJoin{ get; set; } // last name of the employee
        public decimal salary { get; set; }    // Accepts only digits

        //  ========= Object Oriented Class Model ==========
        // many to 1 relationship ==>> (1 List --> many ) 
         Department Dept { get; set; } // department of the employee
        

        // projects ---- 1 Employee can work on many projects
        List<Project> Projects { get; set; } // list of projects the employee is working on




        public bool inservive { get; set; } // true if employee is in service, false if not



    }
} 
