
namespace Exercise2;

public class Exercise
{
    public void CalculateAverage()
    {
        // タスク１　プログラムのバグを修正してください！
        // タスク２　結果を小数で表示してください！
        int num1 = 10;
        int num2 = 20;
        int num3 = 20;
        int average = (num1 + num2 + num3) / 3;
        Console.WriteLine("The average is: " + average);

        double numd1 = 10;
        double numd2 = 20;
        double numd3 = 20;
        double averaged = (numd1 + numd2 + numd3) / 3;
        Console.WriteLine("The average in decimal number is: " + averaged);

    }
}
