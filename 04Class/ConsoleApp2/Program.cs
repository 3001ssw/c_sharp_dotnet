// See https://aka.ms/new-console-template for more information
//this
class Book
{
    string title;
    string description;

    public Book() : this(string.Empty) { }
    public Book(string title) : this(title, string.Empty) { }
    public Book(string title, string description) { this.title = title; this.description = description; }

    public void PrintBookInfo()
    {
        Console.WriteLine("title: " + this.title);
        Console.WriteLine("description: " + this.description);
    }
}

// base
class ElecBook : Book
{
    public ElecBook() : base(string.Empty) { }
    public ElecBook(string title) : base(title, string.Empty) { }
    public ElecBook(string title, string description) : base(title, description) { }

}
class Program
{
    static void Main(string[] args)
    {
        Book book1 = new Book("C# 프로그래밍");
        Book book2 = new Book("C# 프로그래밍2", "개정판");

        book1.PrintBookInfo();
        book2.PrintBookInfo();

        ElecBook book3 = new ElecBook("C# 프로그래밍3", "전자책");
        ElecBook book4 = new ElecBook("C# 프로그래밍4", "전자책 개정판");
        book3.PrintBookInfo();
        book4.PrintBookInfo();
    }
}
