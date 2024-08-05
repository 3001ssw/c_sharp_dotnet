// See https://aka.ms/new-console-template for more information

class Person
{
    int _age;
    public Person(int age) { _age = age; }

    // property
    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    public void PrintAge()
    {
        Console.WriteLine("age: " + _age);
    }

}
class Program
{
    static void Main(string[] args)
    {
        Person person = new Person(10);
        person.PrintAge();
        person.Age = 11;
        person.PrintAge();
        Console.WriteLine("person age: " + person.Age);

    }
}