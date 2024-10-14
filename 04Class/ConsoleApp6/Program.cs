// See https://aka.ms/new-console-template for more information
class Kilogram
{
    protected int x;
    public int Kg
    {
        get
        {
            return x;
        }

        set
        {
            x = value;
        }
    }

    public Kilogram() : this(0)
    {
    }
    public Kilogram(int x)
    {
        this.x = x;
    }

    // 연산자 오버로드
    public static Kilogram operator +(Kilogram op1, Kilogram op2)
    {
        return new Kilogram(op1.x + op2.x);
    }


    public override string ToString()
    {
        string s = this.x + " Kilogram";
        return s;
    }
}
class Pound
{
    protected double x;

    public Pound() : this(0.0) { }
    public Pound(double x)
    {
        this.x = x;
    }


    static public implicit operator Pound(Kilogram op)
    {
        return new Pound(op.Kg * 0.45359237);
    }

    public override string ToString()
    {
        string s = this.x + " Pound";
        return s;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kilogram Kilogram1 = new Kilogram(1);
        Kilogram Kilogram2 = new Kilogram(2);
        Console.WriteLine(Kilogram1.ToString());
        Console.WriteLine(Kilogram2.ToString());

        Kilogram Kilogram3 = Kilogram1 + Kilogram2;
        Console.WriteLine(Kilogram3.ToString());

        Pound pound = Kilogram3;
        Console.WriteLine(pound.ToString());
    }
}