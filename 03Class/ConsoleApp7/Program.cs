// See https://aka.ms/new-console-template for more information

// System.Object
public class A
//public class A : object // 결국 이렇게 선언한 것과 마찬가지
{

}
public class B
//public class B : object // 결국 이렇게 선언한 것과 마찬가지
{

}
public class C
{
    int _value;
    public C(int value) { _value = value; }
}

class Program
{
    public static void Main(string[] args)
    {
        // ToString을 사용하면 클래스 전체 이름 반환
        A a1 = new A();
        Object obj = a1;
        if (obj is A)
            Console.WriteLine(obj.ToString());

        B b1 = new B();
        obj = b1;
        if (obj is B)
            Console.WriteLine(obj.ToString());

        // GetType
        A a2 = new A();
        Type type1 = a2.GetType();
        Console.WriteLine("Name: " + type1.Name);
        Console.WriteLine("FullName: " + type1.FullName);
        Console.WriteLine("IsClass: " + type1.IsClass);
        Console.WriteLine("IsArray: " + type1.IsArray);

        Type type2 = typeof(B);
        Console.WriteLine("Name: " + type2.Name);
        Console.WriteLine("FullName: " + type2.FullName);
        Console.WriteLine("IsClass: " + type2.IsClass);
        Console.WriteLine("IsArray: " + type2.IsArray);

        // Equals
        int x = 10;
        int y = 10;
        // 값 형식은 값 비교
        if (x.Equals(y))
            Console.WriteLine("x equal y");
        else
            Console.WriteLine("x not equal y");

        C c1 = new C(10);
        C c2 = new C(10);
        // 참조 형식은 메모리 비교
        if (c1.Equals(c2))
            Console.WriteLine("c1 equal c2");
        else
            Console.WriteLine("c1 not equal c2");
    }
}