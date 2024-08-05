// See https://aka.ms/new-console-template for more information

// inheritance

class Computer
{
    bool powerOn;
    public void Boot()
    {
        Console.WriteLine("Computer.Boot");
    }
    public void Shutdown()
    {
        Console.WriteLine("Computer.Shutdown");
    }
    public void Reset()
    {
        Console.WriteLine("Computer.Reset");
    }
}

class Notebook : Computer
{
    public void Shutdown()
    {
        Console.WriteLine("Notebook.Shutdown");
    }
}

class Desktop : Computer
{
    public void Reset()
    {
        Console.WriteLine("Desktop.Reset");
    }
}

// slead: 상속을 더 이상 받지못하게 하는 예약어
//sealed class Pen 
//{
//    
//}
//
//class ElectPen : Pen
//{
//
//}

class Program
{
    static void Main(string[] args)
    {
        Computer computer = new Computer();
        Notebook notebook = new Notebook();
        Desktop desktop = new Desktop();

        computer.Boot();
        computer.Reset();
        computer.Shutdown();
        notebook.Boot();
        notebook.Reset();
        notebook.Shutdown();
        desktop.Boot();
        desktop.Reset();
        desktop.Shutdown();
    }
}