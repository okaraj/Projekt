using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Employee
{
    public int EmployeeID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Title { get; set; }
    public int Age { get; set; }
    List<Employee> lista = new List<Employee>();
    public List<Employee> CreateEmployee()
    {
        Console.WriteLine("Please enter the employees name: ");
        Employee employee = new Employee();
        Random random = new Random();
        employee.FirstName = Console.ReadLine();
        Console.WriteLine("Please enter the Last Name: ");
        employee.LastName = Console.ReadLine();
        Console.WriteLine("Please enter the employees age: ");
        employee.Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Please enter the employee's title");
        employee.Title = Console.ReadLine();
        employee.EmployeeID  = random.Next(0, 999999999);
        lista.Add(employee);
        return lista;
    }

    public List<Employee> ViewEmployees (List<Employee> lista)
    {
        return lista.Where(x => x.FirstName != null).ToList();
        return lista.Where(x => x.LastName != null).ToList();
        return lista.Where(x => x.Age != null).ToList();
        return lista.Where (x => x.EmployeeID != null).ToList();
        return lista.Where (x => x.Title != null).ToList();
    }

    public void DeleteEmployee(List<Employee> lista)
    {
        Console.WriteLine("Choose the Id of the employee that you want to delete. ");
        int deleteId = Convert.ToInt32 (Console.ReadLine());
        var employeeToDelete = lista.FirstOrDefault(x => x.EmployeeID == deleteId);
        if (employeeToDelete != null)
        {
            lista.Remove(employeeToDelete);
            Console.WriteLine("Employee with ID {0} has been deleted.", deleteId);
        }
        else
        {
            Console.WriteLine("No employee found with ID {0}.", deleteId);
        }
    }
}
