using System;

namespace chapter13
{
    // class Program
    // {
    //     static void Main(string[] arg)
    //     {
    //         Console.WriteLine("Form VS Code Editor.");
    //     }
    // }

    // Summary of Points

    //1. automate attributes
    class Person
    {
        public string Name {get; set;}
        public int Age {get; set;}
    }

    //2.implicit type
    class Program
    {
        static void Main(string[] args)
        {
            var stringvariable = "Learning Hard"; // 隐式类型变量在声明时必须被初始化，因为编译器需要通过其赋值来确定其类型
            stringvariable = 2;
        }
    }

    //3.initialator of objects/sets
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person() {Name="String",Age = 25,Weight=60,Height=170}
            Person p1 = new Person {Name="String",Age = 25,Weight=60,Height=170} //与上一行等效，就是说()可以省略
        }
    }

    public class Person
    {
        public string Name {get; set;}
        public int Age {get; set;}
        public int Weight {get; set;}
        public int Height {get; set;}
    }

    //4. anonymous type
    class Program
    {
        static void Main(string[] args)
        {
            //定义了一个匿名对象
            var person = new {Name="String", Age=25};
            Console.WriteLine("{0}的年龄为{1}", person.Name, person.Age);
            
            //定义了一个匿名类型数组
            var personset = new[]
            {
                new {Name="Tom", Age=30},
                new {Name="Vinson", Age=23},
                new {Name="Hyper", Age=20}
            }

            int totalAge = 0;
            foreach (var p in personset)
            {
                totalAge += p.Age;
            }

            Console.WriteLine("所有人年龄总和为：{0}", totalAge);
            Console.Read();
        }
    }

}