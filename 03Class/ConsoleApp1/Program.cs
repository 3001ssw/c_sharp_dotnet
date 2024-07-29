// See https://aka.ms/new-console-template for more information
class Movie
{
    string name;
    string author;
    int year;
    int month;
    int day;

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