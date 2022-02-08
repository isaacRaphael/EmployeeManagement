using System;
using EmployeeRecords;


namespace EmployeeManagement
{
    class Program {

        static void PrintDetails(Employee employee){

                Console.WriteLine($"{employee.FullName}\t{employee.StaffId.ToString()}\t{employee.EmploymentDate.Date.ToString("dd/MM/yyyy")}\t{employee.JobTittle}\t{employee.Department}");
                Console.WriteLine("");
                
        }
        static void Main(string[] args){

            Employee employee1 = new Employee(1001, "John Adams", new DateTime(2014, 3, 11)){
                Department = "Accounting & Records",
                JobTittle = "Finance Officer"
            };
            

            Employee employee2 = new Employee(1002, "Amaka Okafor", new DateTime(2017, 4, 12)){
                    Department = "Accounting & Records",
                    JobTittle = "Lead Accountant"
            };
                    

            Employee employee3 = new Employee(1003, "Ben Adebayo", new DateTime(2016, 3, 3)){
                    Department = "IT",
                    JobTittle = "IT Support"
            };
            

            Employee employee4 = new Employee(1004, "Tolu King", new DateTime(2020, 8, 11)){
                    Department = "Accounting & Records",
                    JobTittle = "Accountant"
            };
            

            Employee employee5 = new Employee(1005, "Christy Bayo", new DateTime(2019, 3, 11)){
                    Department = "HR",
                    JobTittle = "HR Officer"
            };
            


            Employee[] employeeArray = new Employee[] {employee1,employee2,employee3,employee4,employee5};

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Employee Name \t Id\tEmployment Date\tJob Tittle\tDepartment");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;

            foreach (Employee employee in employeeArray) {    
                PrintDetails(employee);
            }

            Console.ForegroundColor = ConsoleColor.White;

            //Testing ClockIn() Function
            // employee1.ClockIn();

        }
    }
}
