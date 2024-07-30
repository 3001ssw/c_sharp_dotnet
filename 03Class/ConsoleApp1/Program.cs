// See https://aka.ms/new-console-template for more information
class Movie
{
    string name;
    string author;
    int year;
    int month;
    int day;

    // 생성자
    public Movie()
    {
        this.name = "";
        this.author = "";
        this.year = 0;
        this.month = 0;
        this.day = 0;

        Console.WriteLine("Constructor");
    }
    // 소멸자
    ~Movie()
    {
        // Garbage Collector에서 관리하므로 굳이 정의안해도 됨. .NET에서 관리하지 않는 자원인경우만 정의
        Console.WriteLine("Destructor");
    }

    // 한정자 반환값 함수명 인자
    public void SetName(string name)
    {
        this.name = name;
    }
    public string GetName()
    {
        return this.name;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Movie movie = new Movie();
        movie.SetName("titanic");
        System.Console.WriteLine("name: " + movie.GetName());
    }
}