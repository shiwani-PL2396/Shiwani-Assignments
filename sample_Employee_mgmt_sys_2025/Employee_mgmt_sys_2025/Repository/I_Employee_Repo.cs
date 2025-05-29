using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_mgmt_sys_2025.Repository
{
    public interface I_Employee_Repo
    {
        // CRUD operations
        void AddEmployee();            // add employee
        void UpdateEmployee(int employeeId);          // update employee
        void DeleteEmployee(int employeeId);
        void SearchById(int employeeId);         // search employee by ID
        void ListAllEmployees();         // list all employees


    }
}
