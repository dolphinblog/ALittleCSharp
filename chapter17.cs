//本章讲可选参数，即Python中的默认参数，Profoundly inspired by Python, hhh.
using System;
using Microsoft.Office.Interop.Word; //在引用-COM中添加Microsoft Word 1X.0 Object Library就有了该程序集
//从可选参数特性中受益的有C#和COM的互操作，比如操作Microsoft Word.
namespace chapter17
{
    class Program
    {
        static void Main(string[] args)
        {
            Application wordApp = new Application() { Visible = true };

            wordApp.Documents.Add();
            Document wordDoc = wordApp.ActiveDocument;
            Paragraph para = wordDoc.Paragraphs.Add();
            para.Range.Text = "Hello, Vinson.你在学习C#.";

            object filename = @"C:\Users\Administrator\Desktop\Vinson.doc";

            wordDoc.SaveAs(FileName:filename);

            wordDoc.Close();
            wordApp.Application.Quit();

        }
    }
}

//介绍协变性、逆变性
namespace chapter17
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> listobject = new List<object>();
            List<string> liststr = new List<string>();
            
            //协变性指的是泛型类型参数可以从一个派生类隐式地转化为基类
            listobject.AddRange(liststr);//成功
            liststr.AddRange(listobject);//出错

            ////协变性指的是泛型类型参数可以从一个基类隐式地转化为派生类
            IComparer<object> objConparer = new TestComparer();
            IComparer<string> stringComparer = new TestComparer();

            liststr.Sort(objConparer);//正确
            listobject.Sort(stringComparer);//出错
        }
    }
}


