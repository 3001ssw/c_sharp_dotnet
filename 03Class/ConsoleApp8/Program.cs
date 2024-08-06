// See https://aka.ms/new-console-template for more information
// GetHashCode
public class A
{
    int _value;
    public A(int value) { _value = value; }
}


class Program
{
    public static void Main(string[] args)
    {
        A a1 = new A(10);
        A a2 = new A(10);

        Console.WriteLine("a1 Hash Code: " + a1.GetHashCode());
        Console.WriteLine("a2 Hash Code: " + a2.GetHashCode());
    }
}