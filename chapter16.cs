//本章讲解Linq
//Linq主要包含四4个组件：
//1. Linq to Objects
//2. Linq to XML
//3. Linq to DataSet
//4. Linq to SQL
using System;
using System.Linq;
using System.Xml.Linq;

class Program
{
    private static string xmlString = 
        "<Persons>"+
        "<Person Id='1'>"+
        "<Name>张三</Name>"+
        "<Age>18</Age>"+
        "</Person>" +
        "<Person Id='2'>"+
        "<Name>李四</Name>"+
        "<Age>20</Age>"+
        "</Person>" +
        "<Person Id='3'>"+
        "<Name>王五</Name>"+
        "<Age>22</Age>"+
        "</Person>" +
        "</Persons>";

    static void Main(string[] args)
    {
        Console.WriteLine("Using Linq to query Xml string, results:");
        UsingLinqLinqtoXMLQuery();
        Console.Read();
    }

    private static void UsingLinqLinqtoXMLQuery()
    {
        XElement xmlDoc = XElement.Parse(xmlString); //将简单的xmlString转换为XElement类实例

        // 下面这段类似SQL语句的东西就是Linq，像是SQL的颠倒。
        var queryResults = from element in xmlDoc.Elements("Person") //查询出所有"<Person>XXX</Person>"元素(element)
                           where element.Element("Name").Value == "李四"//对上步筛选出的element进行进一步筛选
                           select element;//获得经过筛选后的element
        
        foreach (var xele in queryResults)
        {
            Console.WriteLine("Name: "+xele.Element("Name").Value +" "+ "Id: " + xele.Attribute("Id").Value);
        }
    }
}