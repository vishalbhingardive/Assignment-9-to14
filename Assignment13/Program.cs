
Person p1 = new Person();
p1.age = 10;
p1.name = "A";

Person p2 = new Person();
p2.age = 20;
p2.name = "B";

p1.saysHi();
p2.saysHi();

swap1(p1, p2);

p1.saysHi();
p2.saysHi();

void swap1(Person psn1, Person psn2)
{
    Person temp = psn1;
    psn1 = psn2;//unneccessary assignment to psn1
    psn2 = temp;//unneccessary assignment to psn2
}
public class Person
{
    
    public int age;
    public String name;

    public void saysHi()
    {
        Console.WriteLine(name + "[" + age + "] says hi");
    }
}


//13.Predict the output of the above code, We need proper explanation of the program.

