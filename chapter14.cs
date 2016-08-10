using System;
using System.Windows.Forms; 
//在VS Studio中解决方案管理器中的“引用”上右键，选择该程序集，在前面打勾，点击确定，即可

class Program
{
    static void Main(string[] args)
    {
        Button button1 = new Button();
        button1.Text = "点击我";

        button1.Click += delegate(object sender, EventArgs e)
        {
            ReportEvent("Click事件", sender, e);
        };

        button1.KeyPress += delegate(object sender, KeyPressEventArgs e)
        {
            ReportEvent("KeyPress事件，即键盘按下事件", sender, e);
        };

        Form form = new Form();
        form.Name = "在控制台中创建的窗体";
        form.AutoSize = true;
        form.Controls.Add(button1);
        Application.Run(form);
    }

    private static void ReportEvent(string title, object sender, EventArgs e)
    {
        Console.WriteLine("发生的事件为：{0}", title);
        Console.WriteLine("发生事件的对象为：{0}", sender);
        Console.WriteLine("发生事件参数为：{0}", e.GetType());
        Console.WriteLine();
        Console.WriteLine();
    }
}