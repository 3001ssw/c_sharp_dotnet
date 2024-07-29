// See https://aka.ms/new-console-template for more information

//if문
System.Char ch = 'A';
System.UInt16 ui16 = 0x0041;
if (ch == ui16)
    Console.WriteLine("Unicode A is 0x0041");
else
    Console.WriteLine("Unicode A is not 0x0041");

// 삼항연산자
bool isSame = (ch == 'A') ? true : false;
Console.WriteLine("is Same? " + isSame);

//switch문
switch (ch)
{
    case 'A':
        Console.WriteLine("A");
        break;
    case 'B':
        Console.WriteLine("B");
        break;
    case 'C':
        Console.WriteLine("C");
        break;
    default:
        Console.WriteLine("Else");
        break;
}

System.String text = "Kor";
switch (text)
{
    case "Kor":
    case "한국":
        Console.WriteLine("한국입니다.");
        break;
    case "Jap":
    case "일본":
        Console.WriteLine("일본입니다.");
        break;
    case "USA":
    case "미국":
        Console.WriteLine("미국입니다.");
        break;
    default:
        Console.WriteLine("그 외 국가 입니다.");
        break;
}

// for문
for(int i = 0; i < 10; i++)
{
    Console.WriteLine("i: " + i);
}

// foreach문
int[] arr = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
foreach(int element in arr)
{
    Console.WriteLine("element: " + element);
}

//while문
int Num = 0;
while(Num < 10)
{
    Console.WriteLine("Num: " + Num);
    Num++;
}