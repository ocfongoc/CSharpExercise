using System.Text;

namespace Exercise3;

public class Exercise
{
    public void PrintHelloWorld()
    {
        string hello = "ハロー";
        string beautifulButCruelWorld = "この美しき殘酷な世界";
        //　タスク コンソールに以下のテキストを表示する。
        // ハロー、
        //   この美しき殘酷な世界。  
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine($"{hello}、\n\t{beautifulButCruelWorld}。");
       
    }
}
