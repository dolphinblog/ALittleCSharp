//本章讲拓展方法
using System;
namespace CurrentNamespace
{
    using CustomNamespace;
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person {Name = "Vinson"};
            p.Print();
            p.Print("Hello");
            Console.Read();
        }
    }

    public class Person
    {
        public string Name {get; set;}
    }

    public static class Extensionclass
    {
        public static void Print(this Person per)
        {
            Console.WriteLine("调用的是当前命名空间(CurrentNamespace)下的扩展方法输出，姓名为：{0}", per.Name);
        }
    }
}

namespace CustomNamespace
{
    using CurrentNamespace;

    public static class Extensionclass
    {
        public static void Print(this Person per)
        {
            Console.WriteLine("调用的是CustomNamespace命名空间下的扩展方法输出，姓名为：{0}", per.Name);
        }

        public static void Print(this Person per, string s)
        {
            Console.WriteLine("调用的是CustomNamespace命名空间下的扩展方法输出，姓名为：{0}，"+"附加字符串为:{1}", per.Name,s);
        }
    }
}