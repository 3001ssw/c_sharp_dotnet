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

// 문자형 - 문자
System.Char ch = 'A';
Console.WriteLine("ch: " + ch);

System.Char newline = '\n'; // 뉴라인
Console.Write(newline);
Console.WriteLine(ch);

System.Char tab = '\t'; // 탭
Console.Write(tab);
Console.WriteLine(ch);

System.Char escape = '\\'; // escape
Console.WriteLine(escape);

System.Char unicode = '\uAEC0'; // 유니코드
Console.WriteLine("U+AEC0: " + unicode);

// 문자형 - 문자열
System.String text1 = "Hello, World";
Console.WriteLine(text1);

System.String text2 = "\tHello,\tWorld"; // escape
Console.WriteLine(text2);

System.String text3 = "\"Hello,World\""; // 쌍따옴표 표시
Console.WriteLine(text3);

System.String text4 = @"\tHello,\tWorld"; // 그대로 표시
Console.WriteLine(text4);


// boolean
bool bIsRealNumber = false;
Console.WriteLine(bIsRealNumber);