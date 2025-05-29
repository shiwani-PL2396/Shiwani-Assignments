using Employee_mgmt_sys_2025.Repository;

namespace Employee_mgmt_sys_2025
{
    internal class EmployeeApp
    {
        // 1 Private field
        private readonly I_Employee_Repo _employeeRepository;
        // 2. Constructor injection
        public EmployeeApp(I_Employee_Repo employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }   
      
        static void Main(string[] args)
        {
            // Menu driven
            while (true)
            {
                Console.WriteLine("/nEmployee Management System");
                Console.WriteLine("1. Add Employees");
                Console.WriteLine("2. Update Emoliyees");
                Console.WriteLine("3. Search Employees by 10");
                Console.WriteLine("4. Delete Employee");
                Console.WriteLine("5. List all Employees");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Enter ur choice 1-6");

                // check choice
                if (int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 6)
                {
                    Console.WriteLine("Invalid choice.Please try again");
                    continue;
                }

                // Go to respective process
                try
                {
                  switch (Choice)
                    {
                        case 1:
                            // Add Employee
                            Console.WriteLine("Enter Employee ID: ");
                        // Replace the problematic line in case 1 with the following code to fix the errors:

                        case 1:
                            // Add Employee
                            Console.WriteLine("Enter Employee ID: ");
                            int id = int.Parse(Console.ReadLine() ?? "0");
                            Console.WriteLine("Enter Employee Name: ");
                            string name = Console.ReadLine() ?? string.Empty;
                            Console.WriteLine("Enter Employee Department: ");
                            string department = Console.ReadLine() ?? string.Empty;

                            var employee = new Employee
                            {
                                Id = id,
                                Name = name,
                                Department = department
                            };

                            _employeeRepository.AddEmployee(employee);
                            Console.WriteLine("Employee added successfully.");
                            break;
                           EmployeeApp.Employee_repo.Add employee()
                            break;
                        case 2:
                            // Update Employee
                            Console.WriteLine("update employee");
                            break;
                        case 3:
                            Console.WriteLine("Search employee by ID");
                            // Search Employee
                            break;
                        case 4:
                            // Delete Employee
                            Console.WriteLine("Delete employee");
                            break;
                        case 5:
                            // List all Employees
                            Console.WriteLine("List all employees");
                            break;
                        case 6:
                            // Exit
                            Console.WriteLine("Exiting the application...");
                            return;
                    }

                }
                catch (Exception ex)
                { 
                Console.WriteLine($"unexpected error occured : {ex.Message}");
                }


                    
                    
                        
            }



            //Pause screen
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
