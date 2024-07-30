// See https://aka.ms/new-console-template for more information

class Person
{
    public string _name;

    public Person(string name)
    {
        _name = name;
        Console.WriteLine("public Person 실행(name: " + name +")");
    }

    static Person()
    {
        // 정적 함수가 호출되거나, 객체가 생성되면 1회 실행
        Console.WriteLine("static Person 실행");
    }

    public static void WritePerson()
    {
        Console.WriteLine("WritePerson");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person.WritePerson();
        Person person = new Person("hi");
    }
}