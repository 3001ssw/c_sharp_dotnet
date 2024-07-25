// See https://aka.ms/new-console-template for more information

// 리터럴 샘플
string text = "Hello World";
int num = 10;
char ch = 'A';

// 변수
int No = 20; // 저장소 이름: No, 크기: 4Byte, 값: 20

// 값 형식
int a = 5;
int b = a;
Console.WriteLine("a: " + a);
Console.WriteLine("b: " + b);

// 참조 형식
string text1 = "Hello World";
string text2 = text1;
Console.WriteLine("text1: " + text1);
Console.WriteLine("text2: " + text2);

//string text3; // error
string text3 = null;

// 배열
int[] arr1 = new int[5] {1,2,3,4,5}; // 배열 요소 개수 지정
int[] arr2 = new int[] {1,2,3,4,5,6,7,8,9,10}; // 배열 요소 개수 미지정

// 다차원 배열
int[,] arr3 = new int[5, 10]; // 2차원 배열
int[,,] arr4 = new int[5, 10, 15]; // 3차원 배열

// 다차원 배열 초기화
int[,] arr5 = new int[3, 2] { {0, 1}, {2, 3}, {4, 5} };

// 가변 배열
int[][] arr6 = new int[2][];
arr6[0] = new int[10]; // 0번째엔 10개의 요소
arr6[1] = new int[20]; // 1번째엔 20개의 요소