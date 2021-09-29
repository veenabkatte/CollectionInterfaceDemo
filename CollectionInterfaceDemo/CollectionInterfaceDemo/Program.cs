using System;

namespace CollectionInterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee { EmpCode = 100, EmpName = "Scott", Email = "scott@gmail.com" };
            Employee employee2 = new Employee { EmpCode = 101, EmpName = "Tiger", Email = "tiger@gmail.com" };
            Employee employee3 = new Employee { EmpCode = 102, EmpName = "Smith", Email = "smith@gmail.com" };

            using (Employees employees = new Employees())
            {
                employees[0] = employee1;
                employees[1] = employee2;
                employees[2] = employee3;

                foreach (var emp in employees)
                {
                    Console.WriteLine($"Code={emp.EmpCode}\tName={emp.EmpName}\tEmail={emp.Email}");
                }
            }
            Console.ReadLine();
        }
    }
}
