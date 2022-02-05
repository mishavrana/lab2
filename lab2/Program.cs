using System;
class Program
{

    static void Main(string[] args)
    {

        ChooseTask choose = new ChooseTask();
        TaskOne task1 = new TaskOne();

        int task = choose.Choose();

        switch (task)
        {
            case 1:
                task1.Calculate();
                break;
            case 2:
                break;
            case 3:
                break;
            default:
                Console.WriteLine("Something went wrong!");
                break;
        }

    }
}
