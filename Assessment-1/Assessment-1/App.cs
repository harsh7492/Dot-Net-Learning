using System;
using System.Collections.Generic;
using System.Dynamic;

namespace EmployeeApp
{
    class Employee
    {
        public long id;
        public string name;
        public string department;
        public long salary;
    }

    class Program   
    {
        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();
            int choice;

            
                Console.WriteLine("1. Add Employee");
                Console.WriteLine("2. Update Employee");
                Console.WriteLine("3. Delete Employee");
                Console.WriteLine("4. Search Employee");
                Console.WriteLine("5. List All Employees");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
            while (true) { 
                switch (choice)
                {
                    case 1:
                        Employee e = new Employee();
                        Console.Write("Enter ID: ");
                        e.id = Convert.ToInt64(Console.ReadLine());
                        Console.Write("Enter Name: ");
                        e.name = Console.ReadLine();
                        Console.Write("Enter Department: ");
                        e.department = Console.ReadLine();
                        Console.Write("Enter Salary: ");
                        e.salary = Convert.ToInt64(Console.ReadLine());
                        list.Add(e);
                        Console.WriteLine("Employee Added.\n");
                        break;

                    case 2:
                        Console.Write("Enter ID to update: ");
                        long uid = Convert.ToInt64(Console.ReadLine());
                        Employee u = list.Find(x => x.id == uid);

                        if (u != null)
                        {
                            Console.Write("New Name: ");
                            u.name = Console.ReadLine();
                            Console.Write("New Department: ");
                            u.department = Console.ReadLine();
                            Console.Write("New Salary: ");
                            u.salary = Convert.ToInt64(Console.ReadLine());
                            Console.WriteLine("Updated.\n");
                        }
                        else
                        {
                            Console.WriteLine("Not Found.\n");
                        }
                        break;

                    case 3:
                        Console.Write("Enter ID to delete: ");
                        long did = Convert.ToInt64(Console.ReadLine());
                        Employee d = list.Find(x => x.id == did);

                        if (d != null)
                        {
                            list.Remove(d);
                            Console.WriteLine("Deleted.\n");
                        }
                        else
                        {
                            Console.WriteLine("Not Found.\n");
                        }
                        break;

                    case 4:
                        Console.Write("Enter ID to search: ");
                        long sid = Convert.ToInt64(Console.ReadLine());
                        Employee s = list.Find(x => x.id == sid);

                        if (s != null)
                        {
                            Console.WriteLine("ID: " + s.id);
                            Console.WriteLine("Name: " + s.name);
                            Console.WriteLine("Department: " + s.department);
                            Console.WriteLine("Salary: " + s.salary + "\n");
                        }
                        else
                        {
                            Console.WriteLine("Not Found.\n");
                        }
                        break;

                    case 5:
                        if (list.Count == 0)
                        {
                            Console.WriteLine("No Employees.\n");
                        }
                        else
                        {
                            foreach (var a in list)
                            {
                                Console.WriteLine("ID: " + a.id);
                                Console.WriteLine("Name: " + a.name);
                                Console.WriteLine("Department: " + a.department);
                                Console.WriteLine("Salary: " + a.salary);
                                Console.WriteLine();
                            }
                        }
                        break;

                    case 6:
                        Console.WriteLine("Exiting...");
                        
                        break;

                    default:
                        Console.WriteLine("Invalid Choice.\n");
                        break;
                }

            }
        }
    }
}
