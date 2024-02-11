int n = (int)MonthName.February;

MonthName month;
month = MonthName.May;



void SwitchExample()
{
    int n = 10;
    string name = "bob";

    Console.WriteLine(Calc(10, 20, '+'));
    Console.WriteLine(CalcLambda(10, 20, '&'));

    //switch(name)
    //{
    //    case "bob":
    //    case "joe":
    //        Console.WriteLine("Hello joe"); break;
    //    default: Console.WriteLine("None"); break;
    //}

    int Calc(int a, int b, char sign)
    {
        //switch(sign)
        //{
        //    case '+': return a + b;
        //    case '-': return a - b;
        //    case '*': return a * b;
        //    case '/': return a / b;
        //    default: return 0;
        //}

        //int result = sign switch
        //{
        //    '+' => a + b,
        //    '-' => a - b,
        //    '*' => a * b,
        //    '/' => a / b,
        //    _ => 0
        //};
        //return result;

        //int result = sign switch
        //{
        //    '+' => a + b,
        //    '-' => a - b,
        //    '*' => a * b,
        //    '/' => a / b
        //    //_ => 0
        //};
        //return result;

        return sign switch
        {
            '+' => a + b,
            '-' => a - b,
            '*' => a * b,
            '/' => a / b
        };
    }

    int CalcLambda(int a, int b, char sign) => sign switch
    {
        '+' => a + b,
        '-' => a - b,
        '*' => a * b,
        '/' => a / b,
        _ => 0
    };
}

void ParamsExample()
{
    int[] array = { 2, 3, 4 };

    Console.WriteLine(Sum(array, 1, 2, 3, 4));
    Console.WriteLine(Sum(array, 11, 22, 33, 44, 55, 66));

    int Sum(int[] array, params int[] numbers)
    {
        int result = 0;
        foreach (int n in numbers)
            result += n;
        return result;
    }

}

void ArgsReferncesExample()
{
    int n = 20, m = 30;

    Console.WriteLine(n + " " + m);
    Swap(ref n, ref m);
    Console.WriteLine(n + " " + m);

    int number;
    Set100(out number);
    Console.WriteLine(number);

    int d = 25;
    Console.WriteLine(Sqr(in d));


    int DoubleNum(ref readonly int n)
    {
        //n = 2 * n;
        return n * 2;
    }

    int Sqr(in int num)
    {
        //num = num * num;
        return num * num;
    }

    void Set100(out int n)
    {
        n = 100;
    }

    void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
}

void ArraysExample()
{
    int size = 10;
    int[] arrayInt1 = new int[10];
    int[] arrayInt2 = new int[size];
    int[] arrayInt3 = new int[] { 1, 2, 3, 4, 5 };
    int[] arrayInt4 = new[] { 10, 20, 30 };
    int[] arrayInt5 = { 111, 222, 333 };

    string[] names = { "Bob", "Joe", "Sam" };

    //for(int i = 0; i < arrayInt5.Length; i++)
    //    Console.WriteLine(arrayInt5[i]);
    //Console.WriteLine();

    for (int i = 0; i < names.Length; i += 2)
    {
        names[i] = "* " + names[i] + " *";
        Console.WriteLine(names[i]);
    }

    Console.WriteLine();

    foreach (string name in names)
    {
        //name = "* " + name + " *";
        Console.WriteLine(name);
    }

    Console.WriteLine();

    //Console.WriteLine(names[^1]);
    for (int i = 1; i <= names.Length; i++)
        Console.WriteLine(names[^i]);
    Console.WriteLine();

    int[,] matrix1;
    int[,] matrix2 = new int[3, 5];
    int[,] matrix3 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
    int[,] matrix4 = new int[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
    int[,] matrix5 = new[,] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
    int[,] matrix6 = { { 1, 2 }, { 5, 6 }, { 9, 10 } };

    int[,,] cube = new int[2, 3, 4];

    Console.WriteLine(matrix5.GetLength(0));
    Console.WriteLine(matrix5.GetLength(1));

    Console.WriteLine();

    Console.WriteLine(cube.GetLength(0));
    Console.WriteLine(cube.GetLength(1));
    Console.WriteLine(cube.GetLength(2));

    int[][] zarray = new int[3][];
    for (int i = 0; i < zarray.GetLength(0); i++)
        zarray[i] = new int[i + 3];

    for (int i = 0; i < zarray.GetLength(0); i++)
    {
        for (int j = 0; j < zarray[i].Length; j++)
            Console.Write(zarray[i][j].ToString() + " ");
        Console.WriteLine();
    }
}

void OperationsConstructsExample()
{
    // +, -, *, /, ++, --, %
    // &, |, ^, ~, <<, >>
    // <, >, <=, >=, ==, !=

    // =, +=, &=, /=, %=, <<=, 
    // a ?=...     <=>     a = a ? ....


    // &&, ||, !     &, |

    int a = 20, b = 30;
    int c = a & b;

    bool f = true, g = false;
    bool r = f & g;
    r = f && g;

    int n = 10;
    if ((n < 0) & (++n < 100))
        Console.WriteLine("Error");
    else
        Console.WriteLine(n);

    if ((n > 0) | (++n < 100))
        Console.WriteLine(n);
    else
        Console.WriteLine("Error");

    int m = (n > 0) ? n + 1 : n - 1;

    switch (n)
    {
        case 1: Console.WriteLine(1); break;
        case 2: Console.WriteLine(2); break;
        default: Console.WriteLine("other"); break;
    }

    for (int i = 0; i < 10; i++)
        Console.WriteLine(i + 1);

    float x = 0;
    while (x < 1)
    {
        Console.WriteLine(x);
        x += 0.1F;
    }

    do
    {
        Console.WriteLine(x);
        x += 1.1F;
    } while (x < 10);
}

void ConsoleEample()
{
    void PrintHello()
    {
        Console.WriteLine("Hello");
    }

    int number;

    Console.Write("Введите число: ");
    var snumber = Console.ReadLine();

    number = Convert.ToInt32(snumber);
    Console.WriteLine(number + 100);

    //if(Int32.TryParse(snumber, out number))
    //    Console.WriteLine(number + 100);
    //else
    //    Console.WriteLine("Error!");

    //try
    //{
    //    number = Int32.Parse(snumber);
    //    Console.WriteLine(number + 100);
    //}
    //catch(Exception e)
    //{
    //    Console.WriteLine("Error!" + e.Message);
    //}

    //var key = Console.ReadKey(true);
    //Console.WriteLine(key.Key.ToString());
}

void WelcomeEaxample()
{
    PrintStars(15);
    Console.WriteLine("Hello, World!");
    PrintStars(15);

    string s = "Hello";
    const int n = 100;

    float x = 34.56F;

    bool flag = true;
    Console.WriteLine(flag);

    byte b1;
    System.Byte b2;

    b1 = 34;

    uint nn = 234U;
    long mm = 234L;

    decimal mon = 234.54M;

    System.Object ob1 = nn;
    object obj2;
}

void PrintStars(int n)
{
    for(int i = 0; i < n; i++)
        Console.Write("*");
    Console.WriteLine();
}

class User { }

enum MonthName
{
    January = 1,
    February,
    March,
    April,
    May,
};

enum Region
{
    Tula = 71,
    Irkuisk = 38,
};
