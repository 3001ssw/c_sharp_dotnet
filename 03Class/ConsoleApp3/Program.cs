using Chemical.Molecule;

namespace Math
{
    class Calc
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }
    }
}

namespace Chemical.Molecule
{
    class Atomic
    {
        public string Sum(char x, char y)
        {
            string str = x.ToString() + y.ToString();
            return str;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        Math.Calc calc = new Math.Calc();
        Chemical.Molecule.Atomic atom1 = new Chemical.Molecule.Atomic();
        Atomic atom2 = new Atomic();

        Console.WriteLine("1 + 2 = " + calc.Sum(1, 2));
        Console.WriteLine("a + b = " + atom1.Sum('a', 'b'));
        Console.WriteLine("c + d = " + atom2.Sum('c', 'd'));
    }
}