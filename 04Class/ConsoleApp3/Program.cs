// See https://aka.ms/new-console-template for more information
// 함수 오버라이드
class Animal
{
    virtual public void Move() // 상속하는 쪽은 virtual
    {
        Console.WriteLine("Aniaml Move");
    }

    virtual public void Speak()
    {
        Console.WriteLine("Open Mouse");
    }
}

class Person : Animal
{
    override public void Move() // 상속 받는 쪽은 override
    {
        Console.WriteLine("Person Move");
    }

    override public void Speak()
    {
        base.Speak(); // 부모 함수 호출
        Console.WriteLine("blah blah");
    }
}

class Dog : Animal
{
    new public void Move() // 명시적으로 재정의 했다는 것을 표현하려면 new 사용
    {
        Console.WriteLine("Dog Move");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person();
        Dog dog = new Dog();

        person.Move();
        dog.Move();

        Animal animal = person;
        animal.Move();

        animal = dog;
        animal.Move();

        Console.WriteLine("---------------------------");
        person.Speak();
    }
}