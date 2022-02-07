using System;
class Program
{

    static void Main(string[] args)
    {

        ChooseTask choose = new ChooseTask();
        TaskOne task1 = new TaskOne();
        TaskTwo task2 = new TaskTwo();
        TaskThree task3 = new TaskThree();
        Rhombus draw = new Rhombus();

        int task = choose.Choose();

        switch (task)
        {
            case 1:
                task1.Calculate();
                break;
            case 2:
                task2.Calculate();
                break;
            case 3:
                task3.Calculate();
                break;
            case 4:
                draw.MainProcess();
            break;
            default:
                Console.WriteLine("Something went wrong!");
                break;
        }

    }
}
