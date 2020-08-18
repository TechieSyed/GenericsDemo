using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsDemo
{
    class Swapper
    {
        public void Swap<T>(ref T value1, ref T value2)
        {
            T temp = value1;
            value1 = value2;
            value2 = temp;
        }
    }

    class SwapperV1<T>
    {
        public T Value { get; set; }
        public void Swap(ref T value1, ref T value2)
        {
            T temp = value1;
            value1 = value2;
            value2 = temp;
        }
        public void Print(T value)
        {
            Console.WriteLine(value);
        }
    }

    interface IPrinter<T>
    {
        void Print(T document);
    }

    class IntPrinter : IPrinter<int>
    {
        public void Print(int document)
        {
            Console.WriteLine(document);
        }
    }

    class StringPrinter : IPrinter<string>
    {
        public void Print(string document)
        {
            Console.WriteLine(document);
        }
    }

    class Employee
    {

    }

    class Que<T> where T : struct//IComparable//class
    {

    }
    class Program
    {
        delegate void MyDelegate<T>(T input);
        delegate void SomeDelegate(ref int t1, ref int t2);
        static void Main(string[] args)
        {
            #region Code
            //Swapper sw = new Swapper();
            //int a=10, b = 20;
            //sw.Swap<int>(ref a, ref b);
            //Console.WriteLine("a={0}, b={1}", a, b);

            //bool b1 = true, b2 = false;
            //sw.Swap<bool>(ref b1, ref b2);
            //Console.WriteLine("b1={0}, b2={1}", b1, b2);

            //SwapperV1<int> swv = new SwapperV1<int>();
            //int a = 10, b = 20;
            //swv.Swap(ref a, ref b);
            //Console.WriteLine("a={0}, b={1}", a, b);
            //swv.Print(a);
            //swv.Print(b);

            //var printer = new IntPrinter();
            //printer.Print(10);
            #endregion

            //var obj1 = new MyDelegate<int>(Demo);
            //var obj2 = new MyDelegate<string>(Demo01);

            //obj1(100);
            //obj2("Cognizant");

            ////var s = new SwapperV1<int>();
            ////var d = new SomeDelegate(s.Swap);

            //var obj3 = new MyDelegate<Employee>(Demo02);

            var q = new Que<int>();
            var q1 = new Que<Employee>();

            Console.ReadKey();
        }

        static void Demo(int x)
        {
            Console.WriteLine("x=" + x);
        }
        static void Demo01(string x)
        {
            Console.WriteLine("x=" + x.Length);
        }
        static void Demo02(Employee x)
        {
            Console.WriteLine("x=" + x.ToString());
        }
    }
}
