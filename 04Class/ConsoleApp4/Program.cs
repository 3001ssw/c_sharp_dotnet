// See https://aka.ms/new-console-template for more information

public class Point : object
{
    protected int x, y;
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public override string ToString()
    {
        return "x: " + this.x + ", " + this.y;
    }

    public override int GetHashCode()
    {
        return x.GetHashCode() ^ y.GetHashCode();
    }
    public override bool Equals(object? obj)
    {
        Point point = obj as Point;
        if (point == null)
            return false;

        if (this.x == point.x && this.y == point.y)
            return true;
        else
            return false;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Point pnt1 = new Point(10, 20);
        Console.WriteLine(pnt1.ToString());

        Point pnt2 = new Point(10, 20);
        bool bEquals = pnt1.Equals(pnt2);
        Console.WriteLine("equals? " + bEquals);
    }
}