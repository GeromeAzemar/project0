using System;

namespace EmployeeManagement
{
    class Program
    {
        static void Main(string[] args)
        {
        //     Employee emp = new Employee();
                Developer dev = new Developer() {
                    empNo = 101,
                    empName = "Gerome",
                    empSalary = 45000,
                    empIsPermant = true
                };

                   HR hr = new HR() {
                    empNo = 201,
                    empName = "Daryl",
                    empSalary = 40000,
                    empIsPermant = true
                };

                   Manager man = new Manager() {
                    empNo = 301,
                    empName = "Nikhil",
                    empSalary = 80000,
                    empIsPermant = true
                };


                System.Console.WriteLine("Gerome's Salary is " + dev.getBonus(3));

        }
    }
}
