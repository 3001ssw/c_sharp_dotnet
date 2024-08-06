// See https://aka.ms/new-console-template for more information
// Array
class Program
{
    // 배열 정보 출력
    private static void OutputArrayInfo(Array arr)
    {
        Console.WriteLine("배열 차원 수: " + arr.Rank);
        Console.WriteLine("배열 요소 수: " + arr.Length);
        Console.WriteLine("==================================");
    }

    //배열 요소 출력
    private static void OutputArrayElement(Array arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr.GetValue(i) + ", ");
        }
        Console.WriteLine("");
        Console.WriteLine("==================================");
    }
    static void Main(string[] args)
    {
        bool[,] arrBool = new bool[,] { { true, true }, { false, false } };
        OutputArrayInfo(arrBool);

        int[,,] arrInt1 = new int[,,] {
            {
                { 1, 2, 3 },
                { 4, 5, 6 },
                { 7, 8, 9 }
            },
            {
                { 10, 11, 12 },
                { 13, 14, 15 },
                { 16, 17, 18 }
            }
        };
        OutputArrayInfo(arrInt1);

        int[] arrInt2 = new int[] { 7, 4, 5, 6, 9, 2, 1 };
        OutputArrayInfo(arrInt2);
        OutputArrayElement(arrInt2);

        Console.WriteLine("sort");
        Array.Sort(arrInt2);
        OutputArrayElement(arrInt2);

        int[] arrInt3 = new int[arrInt2.Length];
        Array.Copy(arrInt2, arrInt3, arrInt3.Length);
        OutputArrayInfo(arrInt3);
        OutputArrayElement(arrInt3);
    }
}