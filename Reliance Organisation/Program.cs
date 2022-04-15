//9.Reliance Organization Want to store Employee Information. Make a class used that class to store employee information
//Note—A. Constructor, static variable, and this keyword must be used
//B.Employee information should be updated without using getter and setter
//C.Display Method should be in class
//10.Create a class and Count the Number of Objects have you created of that class and display.
Employee e = new Employee(1, "Vishal", 200000, "Sofware");
e.UpdateSalary(2000000);
int a = Employee.UpdateId(11);
e.Display();

class Employee
{
    public static int Id;
    string Name;
    long Salary;
    string Desg;
    public  Employee(int id, string name, long salary, string desg)
    {
        Id = id;   
        this.Name = name;
        this.Salary = salary;
        this.Desg = desg;
    }
    public static int UpdateId(int id)
    {
        Id=id;
        return id;
    }
    public void UPdateName(string name)
    {
        this.Name = name;
    }
    public void UpdateSalary(int salary)
    {
        this.Salary = salary;
    }
    public void UpdateDesg(string desg)
    {
        this.Desg = desg;
    }
    public void Display()
    {
        Console.WriteLine("Employee id:\t     Employee Name:\t Salary \t Designation");
        Console.WriteLine($"{Id,-20} {Name,10} {Salary,15} {Desg,15}");
    }

}
