using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_mgmt_sys_2025.model
{
    public class Department
    {
        // ===== Properties =====
        public int DepartmentId { get; set; } // auto generated 4 digit number
        public string DepartmentName { get; set; } // name of the department

        // ===== 1 to many relationship =====
        List<Employee> Employees { get; set; } // list of employees in the department




    {
    }
}
