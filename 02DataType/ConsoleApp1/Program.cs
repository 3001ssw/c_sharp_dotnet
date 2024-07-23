// See https://aka.ms/new-console-template for more information

// 정수형
int a = 50;
int b = 100;
long c = a + b;

Console.WriteLine(a + "+" + b + "=" + c);

System.Int32 x = 10;
System.Int32 y = 20;
System.Int64 z = x + y;

Console.WriteLine(x + "+" + y + "=" + z);

// 실수형
float f = 1.2f;
double d = 3.5;
decimal money = 1000.0999m;

Console.WriteLine("f: " + f);
Console.WriteLine("d: " + d);
Console.WriteLine("money: " + money);

// 문자형

System.Char ch = 'A';
Console.WriteLine("ch: " + ch);

System.Char newline = '\n';
Console.WriteLine(newline);
Console.WriteLine(ch);

System.Char tab = '\t';
Console.WriteLine(tab);
Console.WriteLine(ch);

System.Char unicode = '\uAEC0';
Console.WriteLine(unicode);
Console.WriteLine(ch);
