using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Employee_mgmt_sys_2025.model;
using Employee_mgmt_sys_2025.Utility;

namespace Employee_mgmt_sys_2025.Repository
{
    public class Employee_repo : I_Employee_Repo
    {
        // create a Dictionary to store employee_Id as key
        // And Employee as Corresponding object
        public static Dictionary<int, Employee> employees = new Dictionary<int, Employee>();
        private static int employeeCounter = 1000; // starting employee id with 1000 for 4 - digit id

        #region Add Employee
        public void AddEmployee()
        {
            // get input from user
            try 
            {
            lblName:
                // Employee ID --Auto Generated 4 digit number starting fron 1000
                // Employee Name
                Console.WriteLine("Employee Name :");
                String name = Console.ReadLine();

                // validate input Name
                bool IsValidInputName = Custom_Validation.IsValidName(name);
                if (IsValidInputName)
                {
                    goto lblName;
                }
            }
        }
        #endregion

        #region Delete Employee
        public void DeleteEmployee(int employeeId)
        {
            // get input from user
            try
            {

            }
            throw new NotImplementedException();


        }
        #endregion

        #region List All Employees
        public void ListAllEmployees()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Search by Id
        public void SearchById(int employeeId)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region UpdateEmployee
        public void UpdateEmployee(int employeeId)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
