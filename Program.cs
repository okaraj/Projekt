using System;
class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee();
        List<Employee> listaPunonjesve = new List<Employee>();
        while (true)
        {
            Console.Clear();
            Console.WriteLine("1. Create Employee");
            Console.WriteLine("2. View Employee");
            Console.WriteLine("3. Delete Employee");
            Console.WriteLine("4. Exit");
            try
            {
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        listaPunonjesve = employee.CreateEmployee();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("1. Per te shfaqur te gjithe punonjesit.");
                        Console.WriteLine("2. Per te shfaqur te gjithe punonjersit me te medhenj se j18 vjec.");
                        Console.WriteLine("3. Per te shfaqur te gjithe punonjesit me te vegjel ose 18 vjec.");
                        try
                        {
                            int choice2 = Convert.ToInt32(Console.ReadLine());
                            if (choice2 == 1)
                            {
                                Console.Clear();
                                var a = employee.ViewEmployees(listaPunonjesve).Where(x => x != null).ToList();
                                if (a.Any(x => x != null))
                                {
                                    foreach (var items in a)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine($"Emri: {items.FirstName}");
                                        Console.WriteLine($"Mbiemrii: {items.LastName}");
                                        Console.WriteLine($"Mosha: {items.Age}");
                                        Console.WriteLine($"titulli: {items.Title}");
                                        Console.WriteLine($"Id: {items.EmployeeID}");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You don't have an employee in this category");
                                }
                            }
                            else if (choice2 == 2)
                            {
                                Console.Clear();
                                var a = employee.ViewEmployees(listaPunonjesve).Where(x => x.Age > 18).ToList();
                                if (a.Any(x => x != null))
                                {
                                    foreach (var items in a)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine($"Emri: {items.FirstName}");
                                        Console.WriteLine($"Mbiemrii: {items.LastName}");
                                        Console.WriteLine($"Mosha: {items.Age}");
                                        Console.WriteLine($"titulli: {items.Title}");
                                        Console.WriteLine($"Id: {items.EmployeeID}");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You don't have an employee in this category");
                                }
                            }
                            else if (choice2 == 3)
                            {
                                Console.Clear();
                                var a = employee.ViewEmployees(listaPunonjesve).Where(x => x.Age <= 18).ToList();
                                if (a.Any(x => x != null))
                                {
                                    foreach (var items in a)
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine($"Emri: {items.FirstName}");
                                        Console.WriteLine($"Mbiemrii: {items.LastName}");
                                        Console.WriteLine($"Mosha: {items.Age}");
                                        Console.WriteLine($"titulli: {items.Title}");
                                        Console.WriteLine($"Id: {items.EmployeeID}");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("You don't have an employee in this category");
                                }
                            }
                            else { Console.WriteLine("Please enter a valid number"); }
                        }
                        catch (Exception ex) { Console.WriteLine(ex.Message); }
                        Console.ReadKey();
                        break;
                    case 3:
                       
                            Console.Clear();
                            employee.DeleteEmployee(listaPunonjesve);
                            Console.ReadKey();
                        
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
        }
    }
}