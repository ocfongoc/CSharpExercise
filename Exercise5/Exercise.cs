namespace Exercise5;

public class Exercise
{
    public void PrintDayOfWeek()
    {
        int day = 3;

        // TODO: Rewrite this if-else structure using a switch statement.
        if (day == 1)
            Console.WriteLine("Monday");
        else if (day == 2)
            Console.WriteLine("Tuesday");
        else if (day == 3)
            Console.WriteLine("Wednesday");
        else
            Console.WriteLine("Another day");
    }
}
