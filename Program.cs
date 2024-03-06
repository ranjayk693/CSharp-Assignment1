using System;

public class Employee
{
    private string Id;
    private string Name;
    private string DepartmentName;

    
    //constructor
    public Employee(string id, string name, string departmentName)
    {
        Id = id;
        Name = name;
        DepartmentName = departmentName;
    }

    // Return the ID with event calling
    public string GetId(){
        return Id;
    }

    // Return the name with event calling
    public string GetName(){ 
        return Name;
    }

    // Return the Department with event calling
    public string GetDepartmentName(){
        return DepartmentName;
    }

    // Update the ID 
    public void UpdateId(string id){
        Id = id;
    }

    // Update the name
    public void UpdateName(string name){
        Name = name;
    }

    // Update the Department
    public void UpdateDepartmentName(string departmentName){
        DepartmentName = departmentName;
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

        //Printing the console data
        Console.WriteLine("Employee Details:");
        Console.WriteLine("ID :"+ employee.GetId());
        Console.WriteLine("Name :"+ employee.GetName());
        Console.WriteLine("Department Name :"+ employee.GetDepartmentName());

        Console.ReadKey(); //wait the console to execute
    }
}
