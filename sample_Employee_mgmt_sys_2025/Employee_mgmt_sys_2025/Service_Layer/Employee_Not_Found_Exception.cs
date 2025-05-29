using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_mgmt_sys_2025.Service_Layer
{
    // (User Defined_Exception)This class is used to handle the exception when an employee is not found in the system
    public class Employee_Not_Found_Exception : Exception
    {
        public class Employee_Not_Found_Exception(int employeeId)
            :base("$ Employee with Id")
        {
             
            {
            }
        }
    }
}
