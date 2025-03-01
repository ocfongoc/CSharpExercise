namespace Exercise6;

public class Exercise
{
    public void SimpleCalculator()
    {
        /*
            簡単なC#計算機プログラムを作成してください。
            このプログラムは、ユーザーの入力に基づいて基本的な算術演算（+, -, *, /）を実行するものです。
            プログラムは以下の要件を満たす必要があります：

            1. ユーザーに2つの数値を入力するように促す。
            2. ユーザーに算術演算（加算、減算、乗算、除算）を選択するように促す。
            3. 選択された演算を実行するために条件分岐を使用する。
            4. 演算の結果をコンソールに出力する。
            5. ゼロ除算の場合、特定のメッセージを表示する。

            注意！
            - プログラムは、演算の結果を正しく処理し、表示する必要があります。
            - 無効な演算やゼロ除算を適切に処理する必要があります。

            テストコードは、あなたの計算機プログラムが特定のシナリオを正しく処理することを確認します。
            詳細は以下の通りです：

            加算テスト：
                入力: 5, 3, +
                期待される出力:
                    Enter the first number:
                    Enter the second number:
                    Choose an operation: +, -, *, /
                    Result: 8

            ゼロ除算テスト：
                入力: 5, 0, /
                期待される出力:
                    Enter the first number:
                    Enter the second number:
                    Choose an operation: +, -, *, /
                    Error: Division by zero is not allowed.

            無効な演算テスト：
                入力: 5, 3, %
                期待される出力:
                    Enter the first number:
                    Enter the second number:
                    Choose an operation: +, -, *, /
                    Invalid operation. Please choose +, -, *, or /.
        */
        // TODO: 計算機のロジックを実装しましょう
        int firstNumber;
        int secondNumber;
        string userInput;
        // TODO: Implement the calculator logic here
        Console.WriteLine("Enter the first number:");
        userInput = Console.ReadLine();
        int.TryParse(userInput, out firstNumber);
        Console.WriteLine("Enter the second number:");
        userInput = Console.ReadLine();
        int.TryParse(userInput, out secondNumber);
        Console.WriteLine("Choose an operation: +, -, *, /");
        userInput = Console.ReadLine();
        if (userInput != "+" && userInput != "-" && userInput != "*" && userInput != "/")
        {
            Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
        }
        else if (userInput == "+")
        {
            Console.WriteLine("Result: " + (firstNumber + secondNumber));
        }
        else if (userInput == "-")
        {
            Console.WriteLine("Result: " + (firstNumber - secondNumber));
        }
        else if (userInput == "*")
        {
            Console.WriteLine("Result: " + (firstNumber * secondNumber));
        }
        else if (secondNumber == 0)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        else
        {
            Console.WriteLine("Result: " + (firstNumber / secondNumber));
        }


    }
}
