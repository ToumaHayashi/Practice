using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("文字を入力してください");
            string name = Console.ReadLine();
            string result = Sub(name);
            Console.WriteLine(result);

            //Console.WriteLine("{0}に{1}", "牡蠣", "外れる");

            //string data = "pen";
            //string data2 = "pineapple";
            //string data3 = "apple";
            //string txt = $"{data} {data2} {data3} {data}.";
            //Console.WriteLine(txt);

            //string a = "アナフィラキシーショック";
            //string b = a.Replace("ショック", "インパクト");
            //Console.WriteLine(a.IndexOf("ィ"));
            //Console.WriteLine(b);

            //string c = "I,love,you";
            //string[] d =c.Split(',');
            //Console.WriteLine(d[1]);
            //for(int i = 0; i < d.Length; i++)
            //{
            //    if (i == 2)
            //    {
            //        Console.Write(d[i] + ".");
            //    }
            //    else
            //    {
            //        Console.Write(d[i] + " ");
            //    }
            //}

            //Console.WriteLine();

            //string Ban = "a,i,u,e,o,A,I,U,E,O";
            //string result = "";

            //try
            //{
            //    Console.WriteLine("ハンドルネームを入力してください");
            //    string name = Console.ReadLine();
            //    if (name.IndexOf("a,i,u,e,o,A,I,U,E,O") != -1)
            //    {
            //        for (int i = 0; i > Ban.Length; i++)
            //        {
            //            name.Replace(Ban[i], "");
            //        }
            //        Console.WriteLine(name);
            //    }
            //    else { Console.WriteLine(name); }
            //}
            //catch
            //{

            //}

            Console.ReadLine();
        }

        //ユーザーに文字列を入力してもらい、最初の2文字と最後の2文字を結合して表示するプログラムを作成してください。
        static public string Sub(string name)
        {
            string origin = "1";
            string a = origin.Replace("1" , $"{name[0]}");
            string b = origin.Replace("1", $"{name[1]}");
            string c = origin.Replace("1", $"{name[name.Length - 2]}");
            string d = origin.Replace("1", $"{name[name.Length - 1]}");

            string result = a + b + c + d;

            return result;
        }




            

        //入力値の３割引きを行う計算するプログラムを作成してください。
        //static public double Discount(double a)
        //{
        //    double value = a * 0.7;
        //    return value;
        //}

        ////int a = 10; を２進数、１６進数で表示するプログラムをそれぞれ書いてください。
        //static public void Change_2(int a)
        //{
        //    Console.WriteLine(Convert.ToString(a,2));
        //}

        //static public void Change_16(int a)
        //{
        //    Console.WriteLine(Convert.ToString(a, 16));
        //}

        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        Console.WriteLine("金額を入力してください。");
        //        int price = int.Parse(Console.ReadLine());
        //        double discount = price * 0.7;
        //        Console.WriteLine("割引価格" + discount + "円");
        //    }
        //    catch(FormatException)
        //    {
        //        try
        //        {
        //            Console.WriteLine("数字ではありません。");
        //            Console.WriteLine("もう一度入力してください。");
        //            int price = int.Parse(Console.ReadLine());
        //            double discount = price * 0.7;
        //            Console.WriteLine("割引価格" + discount + "円");
        //        }
        //        catch (FormatException)
        //        {
        //            Console.WriteLine("数字ではありません。");
        //        }
        //    }
        //    finally
        //    {
        //        Console.WriteLine("これで処理を終了します。");
        //        Console.ReadLine();
        //    }

        //    //int a = 10;
        //    //Change_2(a);
        //    //Change_16(a);
        //    //Console.ReadLine();
        //}





        //public static void Sub(int a,int b,out int x,out int y)
        //{
        //    x = a * b;
        //    y = a / b;
        //}




        //static void Main(string[] args)
        //{
        //    Console.WriteLine(5 % 10);
        //    Console.ReadLine();
        //int a = 5;
        //int b = 3;

        //int x;
        //int y;

        //Sub(a, b, out x, out y);
        //Console.WriteLine(x);
        //Console.WriteLine(y);
        //Console.ReadLine();






        //int num = 0b00000111;
        //Console.WriteLine(Convert.ToString(15,16));
        //Console.ReadLine();

        //&,|,^,~(補数) の練習
        //int num1 = 0b1000;
        //int num2 = 0b1100;
        //int num3 = ~num2;
        ////Console.WriteLine(num3);
        ////Console.WriteLine(Convert.ToString(num3));
        //Console.WriteLine(num1 << 2);
        //Console.ReadLine();

        //int num1 = 0b111001;
        //int num2 = 0b001101;
        //int num3 = num1 ^ num2;    //110100
        //Console.WriteLine(num3);
        //Console.ReadLine();
        //}





        //メソッド仕様：
        //１．円の半径は実数型で引数として受け取る。
        //2.   円周率は基本3.14とする。高精度で求めたいときは、呼び出し元に渡す引数を追加することで、精度を変えることができる。
        //3.  返り値は実数型(double)とする。
        //static public double areaCircle(double r, double Pi = 3.14)
        //{
        //    return r * r * Pi;
        //}

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(areaCircle(5));
        //    Console.ReadLine();
        //}






        //引数の参照渡し、ref装飾詞の練習
        //static public void addNumber(ref int num)
        //{
        //    num++;
        //}

        //static void Main(string[] args)
        //{
        //    int num = 10;
        //    Console.WriteLine(num);
        //    addNumber(ref num);
        //    Console.WriteLine(num);
        //    Console.ReadLine();
        //}





        //static void Main(string[] args)
        //{
        //    double[] weight = new double[] { 44.2, 53.3, 64.64, 37.8, 72.9 }; 
        //    Console.WriteLine(WeightAverage(weight));
        //    Console.WriteLine(WeightAverage(44.2, 53.3, 64.64, 37.8, 72.9));
        //    Console.ReadLine();
        //}

        //static public double WeightAverage(double a, double b)
        //{
        //    return (a + b) / 2;
        //}

        //static public double WeightAverage(double a, double b, double c)
        //{
        //    return (a + b + c) / 3;
        //}

        //static public double WeightAverage(params double[] args)
        //{
        //    return args.Sum() / args.Length;
        //}

        //static public double WeightAverage(double[] args)
        //{
        //    return args.Sum() / args.Length;
        //}





        //オーバーロードの練習
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(add(13));
        //    Console.WriteLine(add(13, 15));
        //    Console.WriteLine(add(13, 15, 18));
        //    Console.ReadLine();
        //}


        //static public int add(int a)
        //{
        //    return a + 1;
        //}

        //static public int add(int a, int b)
        //{
        //    return a + b;
        //}

        //static public int add(int a, int b, int c)
        //{
        //    return a + b + c;
        //}






        //以下のような果物の列挙型（enum）を定義し、その中にいくつかの果物を列挙してください
        //Apple（りんご）、Banana（バナナ）、Orange（オレンジ）、Grapes（ぶどう）、Watermelon（すいか）
        //enum Fruits { apple, banana, orange, grapes, watermelon };

        //上記の果物の列挙型を使用して、ユーザーに果物の名前を入力してもらい
        //その果物が列挙型に含まれているかどうかを判定してください。
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("果物の名前を入力してください");
        //    Console.ReadLine();
        //}

        //static private bool Judgement(string sum)
        //{
        //    string fruits = Console.ReadLine();
        //}






        //春夏秋冬の季節を表す列挙型を作り、季節型を引数にもち、
        //季節に応じて、暑いや寒い、涼しいなどの文字列を返すメソッドを作成してください
        //enum Season { spring, summer, autumu,winter };

        //static void Main(string[] args)
        //{
        //    string situation = SeasonSituation(Season.spring);
        //    Console.WriteLine(situation);
        //    Console.ReadLine();
        //}

        //static private string SeasonSituation(Season sum)
        //{
        //    if(sum == Season.spring) { return "暖かい"; }
        //    else if(sum == Season.summer) { return "暑い"; }
        //    else if(sum == Season.autumu) { return "涼しい"; }
        //    else if(sum == Season.winter) { return "寒い"; }
        //    return "null";

        //}




        //enum型の使い方
        //enum Animal { mouse, cat, bird, dog = 100, koala, pig = 200, lion };

        //static void Main(string[] args)
        //{
        //    Animal animal = Animal.lion;
        //    int ani = (int)Animal.lion;
        //    Console.WriteLine(animal);
        //    Console.WriteLine(ani);
        //    Console.ReadLine();
        //}






        //static void Main(string[] args)
        //{
        //    int n = 15;  //フィボナッチ数列の要素番号
        //    int result = FindFibonacci(n);

        //    Console.WriteLine($"第{n}項は{result}です");
        //    Console.ReadLine();
        //}

        //static public int FindFibonacci(int n)
        //{
        //    if (n < 2)
        //    { return n; }
        //    return FindFibonacci(n - 2) + FindFibonacci(n - 1);
        //}






        //static  void Main(string[] args)
        //{
        //    List<int> num = new List<int>() { 0 };
        //    for(int i = 1; i <= 100; i++)
        //    {
        //        num.Add(i);
        //    }

        //    Console.WriteLine("フィボナッチ数を求める番号を入力してください");
        //    int number = int.Parse(Console.ReadLine());

        //    FindFibonacci(num[number]);
        //}

        //static public int FindFibonacci(int[] num)
        //{

        //    for (int i = 0; i <= a; i++)
        //    {
        //        int Fibonacci += num[a];
        //    }
        //}





        //static void Main(string[] args)
        //{
        //    testArrayWrite();
        //    Console.ReadLine();
        //}

        ////以下のコードを確認し、出力結果を書いてください。
        //static int[] array = new int[] { 1, 2, 4, 5, 6 };

        //static private void changeValues(int[] array)
        //{
        //    array[0] = 2;
        //    array[1] = 4;
        //}

        //static public void testArrayWrite()
        //{
        //    changeValues(array);
        //    foreach (int num in array)
        //    {
        //        Console.WriteLine(num);
        //    }
        //    Console.ReadLine();
        //}




        //"薬草"　= 200円,//"剣"＝500円,//"盾"= 400円
        //で売られている。武器によって値段を返却するプログラムを実装してください。
        //static void Main(string[] args)
        //{
        //    string[] items = { "薬草", "剣", "盾" };
        //    int value = Shop(items[0]);
        //    Console.WriteLine(value + "円");
        //    Console.ReadLine();
        //}

        //static public int Shop(string name)
        //{
        //    if (name == "薬草") { return 200; }
        //    else if (name == "剣") { return 500; }
        //    else if(name == "盾") { return 400; }
        //    else { return 0; }
        //}





        //1つの整数を引数として受け取り、その数が偶数ならtrue、奇数ならfalseを返すメソッドを実装してください
        //static void Main(string[] args)
        //{
        //    if (OddEven(4)){Console.WriteLine("偶数です");}
        //    else { Console.WriteLine("奇数です"); }
        //    Console.ReadLine();
        //}

        //static public bool OddEven(int a)
        //{
        //    return a % 2 == 0;
        //}





        //2つの整数を引数として受け取り、その合計（和）を返すAddメソッドをして実装ください
        //static void Main(string[] args)
        //{
        //    int total = Add(13,25);
        //    Console.WriteLine(total);
        //    Console.ReadLine();
        //}

        //static public int Add(int a,int b)
        //{
        //    return a + b;
        //}





        //体重（小数点を含む）　値を３つ受け取り、平均体重を求め
        //コンソールに出力するメソッドを作成してください。なお処理実行後、値は返却しない。
        //static void Main(string[] args)
        //{
        //    WeightAverage(45.5, 53.8, 63.0);
        //    Console.ReadLine();
        //}

        //static public void WeightAverage(double a, double b, double c)
        //{
        //    double average = (a + b + c) / 3;
        //    Console.WriteLine(average);
        //}






        //static void Main(string[] args)
        //{
        //    List<int> numbers = new List<int> { 5, 2, 9, 1, 7 };

        //    Console.WriteLine("現在のリストの要素は次の通りです");

        //    numbers.Add(10);

        //    numbers.RemoveAt(0);

        //    numbers[2] *= 2;
        //    foreach(int number in numbers)
        //    {
        //        Console.WriteLine(number + " ");
        //    }
        //    Console.ReadLine();
        //}





        //2つの整数を受け取り、そのうちの大きい方の数を返すメソッドを作成してください。
        //static void Main(string[] args)
        //{
        //    int a = 0, b = 0;
        //    Console.WriteLine("1つ目の整数を入力してください");
        //    if (int.TryParse(Console.ReadLine(), out a))
        //    {
        //        Console.WriteLine("2つ目の整数を入力してください");
        //        if (int.TryParse(Console.ReadLine(), out b))
        //        {
        //            int result = Compare(a, b);
        //            Console.WriteLine("大きい数値は" + result + "です");
        //        }
        //        else { Console.WriteLine("無効な数値です"); }
        //    }
        //    else { Console.WriteLine("無効な数値です");}
        //    Console.ReadLine();
        //}

        //public static int Compare(int num1,int num2)
        //{
        //    if(num1 > num2)
        //    {
        //        return num1;
        //    }
        //    else
        //    {
        //        return num2;
        //    }
        //}





        //文字列を受け取り、その文字列の長さを返すメソッドを作成してください。
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("文字を入力してください");
        //    string a = Console.ReadLine();
        //    int b = Stringlength(a);
        //}

        //public static string Stringlength(string mozi)
        //{
        //    int length = mozi.Length;
        //    return mozi;
        //}




        //整数を受け取り、その整数が偶数か奇数かを判定するメソッドを作成してください。
        //static void Main(string[] args)
        //{
        //    int number = 0;
        //    Console.WriteLine("整数を入力してください");
        //    if (int.TryParse(Console.ReadLine(), out number))
        //    {
        //        int sum = OddEven(number);
        //        Console.WriteLine(sum);
        //        Console.ReadLine();
        //    }
        //}

        //public static int OddEven(int num)
        //{
        //    bool even = num % 2 == 0;
        //    int result = even ? 1 : 0;
        //    return num;
        //}




        //文字列を受け取り、その文字列を逆順にしたものを返すメソッドを作成してください。
        //static void Main(string[] args)
        //{
        //    string a = "こんにちわ", b = "こんばんわ";
        //    string result = Reverse(a, b);
        //    Console.WriteLine(result);
        //    Console.ReadLine();
        //}

        //public static string Reverse(string mozi1, string mozi2)
        //{
        //    string reverse = mozi2 + mozi1;
        //    return reverse;
        //}




        //2つの整数を受け取り、それらの平均値を返すメソッドを作成してください。
        //static void Main(string[] args)
        //{
        //    int a = 10, b = 20;
        //    int num = Average(a,b);
        //    Console.WriteLine(num);
        //    Console.ReadLine();
        //}

        //public static int Average(int num1, int num2)
        //{
        //    int ave = (num1 + num2) / 2;
        //    Console.WriteLine(ave);
        //    return ave;
        //}





        //static void Main(string[] args)
        //{
        //public static int output(int a , int b)
        //{
        //    int sum = a + b;
        //    Console.WriteLine(sum);
        //    return sum;
        //}

        //int sum;

        //public static int Sub()
        //{
        //    output(sum(3, 3));
        //}





        //public static float MethodA(float weightA, float weightB, float weightC)
        //{
        //    float ave = (weightA + weightB + weightC) / 3;
        //    return ave;
        //}


        //引数を宣言し、MethodAを呼び出している
        //float result = MethodA(33.0f, 77.0f,88.0f);
        //Console.WriteLine(result);

        //List<int> num = new List<int>() {10, 30, 40, 60 };

        //Console.WriteLine(num);

        //foreach (int i in num)
        //{
        //    Console.WriteLine(i);
        //}




        //for (int i = 0; i < num.Count; i++)
        //{
        //    num[i] *= 2;
        //    Console.WriteLine(num[i]);
        //}





        //num.RemoveAt(1);

        //for (int i = 0; i < num.Count; i++)
        //{
        //    if(i == num.Count - 1)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        //for(int i = 0; i < num.Count; i++)  //配列はLength、ListはCount
        //{
        //    Console.WriteLine(num[i]);
        //}




        //const float tax = 1.1f;
        //const float foodTax = 1.08f;

        ////tax += 100;  これできません

        //float price = 100;
        //float foodPrice = 120;

        //Console.WriteLine(price * tax);
        //Console.WriteLine(foodPrice * foodTax);




        //4行3列の二次元配列が与えられます。配列内の奇数の要素のみを表示するプログラムを作成してください。
        //int[,] matrix = new int[4, 3];

        //for (int i = 0; i < 4; i++)
        //{
        //    for (int j = 0; j < 3; j++)
        //    {
        //        if (matrix[i, j]  % 2 != 0)
        //        {
        //            Console.WriteLine(matrix[i, j]);
        //        }
        //    }
        //}




        //3行4列の二次元配列が与えられます。配列内の全ての要素を表示するプログラムを作成してください。
        //int[,] matrix = new int[3, 4];

        //for (int i = 0; i < 3; i++)
        //{
        //    for (int j = 0; j < 4; j++)
        //    {
        //        Console.WriteLine(matrix[i, j]);
        //    }
        //}




        //4行5列の二次元配列を作成し、それぞれの要素に行番号と列番号の和を代入してください。
        //つまり、matrix[i, j]の値はi + jとなります。
        //int[,] matrix = new int[4, 5];

        //for (int i = 0; i < 4; i++)
        //{
        //    for (int j = 0; j < 5; j++)
        //        {
        //            matrix[i, j] = i + j;
        //        }
        //}





        //3行3列の二次元配列を作成し、全ての要素に1から9までの連続した整数を代入してください。
        //int[,] num = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        //int[,] matrix = new int[3, 3];
        //int count = 1;
        //for (int i = 0; i < 3; i++)
        //{
        //    for (int j = 0; j < 3; j++)
        //    {
        //        matrix[i, j] = count;
        //        count++;
        //    }
        //}




        //1から100までの数値のうち、3と5の両方で割り切れる数値を順に表示する
        //プログラムを作成してください。
        //for (int i = 1; i <= 100; i++)
        //{
        //    if (i % 3 == 0 && i % 5 == 0)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}





        //ユーザーに数値を入力してもらい、その数値が素数かどうかを判定して表示する
        //プログラムを作成してください。
        //int num = 0;

        //Console.WriteLine("数値を入力してください");
        //if (int.TryParse(Console.ReadLine(), out num))
        //{
        //    if(num > 0)
        //    {
        //        bool prime = true;

        //        if (prime)
        //        {
        //            for (int i = 1; i < num; i++)
        //            {
        //                if(num % i == 0)
        //                {
        //                    Console.WriteLine("素数ではありません");
        //                }
        //                else
        //                {
        //                    Console.WriteLine("素数です");
        //                }
        //            }
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("素数ではありません");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("無効な数値です");
        //}





        //ユーザーに整数を入力してもらい、その数値の階乗を計算して表示するプログラムを作成してください。
        //int num = 0;
        //int total = 1;

        //Console.WriteLine("数値を入力してください");
        //if (int.TryParse(Console.ReadLine(), out num))
        //{
        //    for(int i = 1; i <= num; i++)
        //    {
        //        total *= i;
        //    }
        //    Console.WriteLine(total);
        //}
        //else
        //{
        //    Console.WriteLine("無効な数値です");
        //}





        //1から20までの数値を順に表示するプログラムを作成し、ただし数値が5の倍数の場合には
        //代わりに「Buzz」と表示してください。
        //for(int i = 1; i <= 20; i++)
        //{
        //    if(i % 5 == 0)
        //    {
        //        Console.WriteLine("Buzz");
        //    }
        //    else
        //    {
        //        Console.WriteLine(i);
        //    }
        //}





        //ユーザーに数値を入力してもらい、その数値が正の数、負の数、またはゼロかどうかを
        //判定して表示するプログラムを作成してください。
        //int num = 0;

        //Console.WriteLine("数値を入力してください");
        //if(int.TryParse(Console.ReadLine(), out num))
        //{
        //    if(num > 0)
        //    {
        //        Console.WriteLine("正の数です");
        //    }
        //    else if(num < 0)
        //    {
        //        Console.WriteLine("負の数です");
        //    }
        //    else if(num == 0)
        //    {
        //        Console.WriteLine("0です");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("無効な数値です");
        //}





        //int[] numbers = new int[5] { 1, 2 , 4, 5, 6 };

        //for (int i = 0; i <= numbers.Length; i++)
        //{
        //    if (numbers[i] % 2 == 0)
        //    {
        //        Console.WriteLine(numbers[i]);
        //    }
        //}




        //問題5:
        //ユーザーに1つの整数を入力してもらい、その数が3で割り切れるかどうかを判定して
        //結果を表示するプログラムを作成してください。

        /*Console.WriteLine("整数を入力してください");
        int num;
        if (!int.TryParse(Console.ReadLine(), out num))
        {
            Console.WriteLine("無効な入力です");
            return;
        }

        if(num % 3 == 0)
        {
            Console.WriteLine("3で割り切ることのできる数字です");
        }
        else
        {
            Console.WriteLine("3で割り切ることはできません");
        }*/



        //問題4:
        //ユーザーに2つの整数を入力してもらい、それぞれの値が正の数、負の数、またはゼロかどうかを判定して
        //結果を表示するプログラムを作成してください。

        /*Console.WriteLine("1つ目の値を入力してください");
        int num1;
        if (!int.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("無効な入力です");
            return;
        }

        Console.WriteLine("2つ目の値を入力してください");
        int num2;
        if (!int.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("無効な入力です");
            return;
        }

        if(num1 > 0)
        {
            Console.WriteLine("1つ目の値は正の数です");
        }
        else if(num1 < 0)
        {
            Console.WriteLine("1つ目の値は負の数です");
        }
        else
        {
            Console.WriteLine("1つ目の値は0です");
        }

        if (num2 > 0)
        {
            Console.WriteLine("2つ目の値は正の数です");
        }
        else if (num2 < 0)
        {
            Console.WriteLine("2つ目の値は負の数です");
        }
        else
        {
            Console.WriteLine("2つ目の値は0です");
        }*/



        //問題3:
        // ユーザーに年齢を入力してもらい、その年齢に応じて以下のようにメッセージを表示するプログラムを作成してください。

        //0歳から2歳までの場合: "赤ちゃんですね！"
        //3歳から12歳までの場合: "子供ですね！"
        //13歳から19歳までの場合: "若者ですね！"
        //それ以外の場合: "大人ですね！"

        /*Console.WriteLine("年齢を入力してください");
        int age;
        if (!int.TryParse(Console.ReadLine(), out age))
        {
            Console.WriteLine("無効な入力です");
            return;
        }

        if (age >= 0 && age <= 2)
        {
            Console.WriteLine("赤ちゃんですね！");
        }
        else if (age >= 3 && age <= 12)
        {
            Console.WriteLine("子供ですね！");
        }
        else if(age >= 13 && age <= 19)
        {
            Console.WriteLine("若者ですね！");
        }
        else if(age >= 20)
        {
            Console.WriteLine("大人ですね！");
        }*/




        //問題2:ユーザーに2つの整数を入力してもらい、それぞれの値が等しいかどうかを判定して
        //結果を表示するプログラムを作成してください。

        /*Console.WriteLine("1つ目の整数を入力してください");
        int num1;
        int num2;
        if (!int.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("無効な入力です");
            return;
        }
        else
        {
            Console.WriteLine("2つ目の整数を入力してください");
        }

        if (!int.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("無効な入力です");
            return;
        }

        if(num1 == num2)
        {
            Console.WriteLine("2つの値は等しいです");
        }
        else
        {
            Console.WriteLine("2つの値は等しくありません");
        }*/



        //問題1:ユーザーに整数を入力してもらい、その数が偶数か奇数かを判定して表示するプログラムを作成してください。

        /*Console.WriteLine("整数を入力してください");
        int num = int.Parse(Console.ReadLine());

        if(num % 2 == 0)
        {
            Console.WriteLine("偶数です");
        }
        else
        {
            Console.WriteLine("奇数です");
        }*/

        //Console.ReadLine();
        //}
        //}
    }
}
