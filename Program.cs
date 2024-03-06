using System;

public class Employee
{
    private string Id;
    private string Name;
    private string DepartmentName;

    //event in EventHandler Generics of tyoe string
    public event EventHandler<string> MethodCalled;
    //constructor
    public Employee(string id, string name, string departmentName)
    {
        Id = id;
        Name = name;
        DepartmentName = departmentName;
    }

    // Return the ID with event calling
    public string GetId()
    {
        OnMethodCalled("GetId() method called");
        return Id;
    }

    // Return the name with event calling
    public string GetName()
    {
        OnMethodCalled("GetName method called");
        return Name;
    }

    // Return the Department with event calling
    public string GetDepartmentName()
    {
        OnMethodCalled("GetDepartmentName method called");
        return DepartmentName;
    }

    // Update the ID 
    public void UpdateId(string id)
    {
        Id = id;
        OnMethodCalled("UpdateId method called");
    }

    // Update the name
    public void UpdateName(string name)
    {
        Name = name;
        OnMethodCalled("UpdateName() method called");
    }

    // Update the Department
    public void UpdateDepartmentName(string departmentName)
    {
        DepartmentName = departmentName;
        OnMethodCalled("UpdateDepartmentName method called");
    }


    //This method call the MethodCalled event whichever function contain this.
    public void OnMethodCalled(string methodName)
    {
        MethodCalled?.Invoke(this, methodName);  //It will invoke the MethodCalled event with the current instance with method name
    }
}

// Main program
public class Program
{
    public static void Main(string[] args)
    {
        //Getting all the values from the 
        Console.WriteLine("Enter employee details:");
        Console.Write("Id: ");
        string id = Console.ReadLine();
        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Department Name: ");
        string departmentName = Console.ReadLine();

        //Creating the object for Employee class
        Employee employee = new Employee(id, name, departmentName);

        //whenever the method is called then this will print the OnMethodCalled function message
        employee.MethodCalled += (data, method) =>
        {
            Console.WriteLine(method);
        };

        //Printing the console data
        Console.WriteLine("Employee Details:");
        Console.WriteLine("ID :"+ employee.GetId());
        Console.WriteLine("Name :"+ employee.GetName());
        Console.WriteLine("Department Name :"+ employee.GetDepartmentName());

        Console.ReadKey(); //wait the console to execute
    }
}
