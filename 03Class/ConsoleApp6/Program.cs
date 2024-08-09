// See https://aka.ms/new-console-template for more information
//형변환

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

    public void InsertMonitor()
    {
        Console.WriteLine("Desktop.InsertMonitor");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Computer computer = new Computer();
        Notebook notebook = new Notebook();
        Desktop desktop = new Desktop();

        Computer comp = computer;
        comp.Boot();
        comp.Reset();
        comp.Shutdown();
        Console.WriteLine("===================");

        comp = notebook;
        comp.Boot();
        comp.Reset();
        comp.Shutdown();
        Console.WriteLine("===================");

        comp = desktop;
        comp.Boot();
        comp.Reset();
        comp.Shutdown();
        Console.WriteLine("===================");

        // 명시적 형변환
        ////Desktop desk = computer; // 형변환 안됨
        //Desktop desk = (Desktop)computer; // 컴파일은 되지만 에러가 남
        ////desk.InsertMonitor(); // 이것도 에러 발생
        //Console.WriteLine("===================");

        // as, is
        Computer comp1 = desktop as Computer;
        if (comp1 != null)
            comp1.Boot();
        Console.WriteLine("===================");

        Desktop desk = computer as Desktop;
        if (desk != null)
            desk.InsertMonitor();
        Console.WriteLine("===================");

        // is
        comp = computer;
        if (comp is Computer)
            Console.WriteLine("comp is Computer");
        Console.WriteLine("===================");

        comp = notebook;
        if (comp is Computer)
            Console.WriteLine("comp is Computer");
        if (comp is Notebook)
            Console.WriteLine("comp is Notebook");
        Console.WriteLine("===================");

        comp = desktop;
        if (comp is Desktop)
            Console.WriteLine("comp is Desktop");
        Console.WriteLine("===================");

        if (comp is Notebook)
            Console.WriteLine("comp is Notebook");
        Console.WriteLine("===================");
    }
}