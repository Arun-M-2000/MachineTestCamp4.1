using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineTestCamp4._1
{
    class Program1
    {
interface IPayable
        {
            void Deposit(decimal amount);
            void Withdraw(decimal amount);
            decimal CheckBalance();

        }

       
        class Program
        {
            static void Main()
            {
                Dictionary<string, Employee> employees = new Dictionary<string, Employee>();

                while (true)
                {
                    Console.WriteLine("1. Create Employee Account");
                    Console.WriteLine("2. Deposit");
                    Console.WriteLine("3. Withdraw");
                    Console.WriteLine("4. Check Balance");
                    Console.WriteLine("5. Search by Phone Number");

                    Console.WriteLine("6. Exit");

                    Console.Write("Enter your choice: ");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:

                            Console.Write("Enter employee ID: ");
                            string employeeId = Console.ReadLine();

                            if (!employees.ContainsKey(employeeId))
                            {
                                Employee newEmployee = new Employee();
                                
                                Console.Write("Enter employee name: ");
                                newEmployee.Name = Console.ReadLine();

                                Console.Write("Enter employee phone number: ");
                                newEmployee.PhoneNumber = Console.ReadLine();

                                employees[employeeId] = newEmployee;
                                Console.WriteLine("Employee account created.");
                            }

                            else
                            {
                                Console.WriteLine("Employee account with this ID already exists.");
                            }
                            break;

                        case 2:
                            Console.Write("Enter employee ID: ");
                            employeeId = Console.ReadLine();
                            if (employees.ContainsKey(employeeId))
                            {
                                Console.Write("Enter the deposit amount: ");
                                decimal depositAmount = decimal.Parse(Console.ReadLine());
                                employees[employeeId].Deposit(depositAmount);
                            }
                            else
                            {
                                Console.WriteLine("Employee account with this ID does not exist.");
                            }
                            break;

                        case 3:
                            Console.Write("Enter employee ID: ");
                            employeeId = Console.ReadLine();
                            if (employees.ContainsKey(employeeId))
                            {
                                Console.Write("Enter the withdrawal amount: ");
                                decimal withdrawalAmount = decimal.Parse(Console.ReadLine());
                                employees[employeeId].Withdraw(withdrawalAmount);
                            }
                            else
                            {
                                Console.WriteLine("Employee account with this ID does not exist.");
                            }
                            break;

                        case 4:
                            Console.Write("Enter employee ID: ");
                            employeeId = Console.ReadLine();
                            if (employees.ContainsKey(employeeId))
                            {
                                decimal balance = employees[employeeId].CheckBalance();
                                Console.WriteLine($"Employee ID {employeeId} has a balance of ${balance}");
                            }
                            else
                            {
                                Console.WriteLine("Employee account with this ID does not exist.");
                            }
                            break;

                        case 5:
                            Console.Write("Enter the employee's phone number to search: ");
                            string searchPhoneNumber = Console.ReadLine();
                            SearchByPhoneNumber(employees, searchPhoneNumber);
                            break;

                        case 6:
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
            }
        }
        static void SearchByPhoneNumber(Dictionary<string, Employee> employees, string phoneNumber)
        {
            bool found = false;

            foreach (var employee in employees.Values)
            {
                if (employee.PhoneNumber == phoneNumber)
                {
                    Console.WriteLine($" Name: {employee.Name} \n PhoneNumber: {employee.PhoneNumber}");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("No employees with the given phone number found.");
            }
        }

    }
}

