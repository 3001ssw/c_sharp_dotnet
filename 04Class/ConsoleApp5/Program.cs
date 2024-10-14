// See https://aka.ms/new-console-template for more information
class Mathematics
{
    // 메서드 오버로드
    public int Abs(int value)
    {
        return (value > 0) ? value : -value;
    }

    public double Abs(double value)
    {
        return (value > 0) ? value : -value;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Mathematics math = new Mathematics();

        Console.WriteLine(math.Abs(-1));
        Console.WriteLine(math.Abs(-10.29));
    }
}