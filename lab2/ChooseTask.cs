﻿class ChooseTask {

    public int Choose()
    {
        Console.WriteLine("Enter a task number from 1 to 3");
        int taskNumber = int.Parse(s: Console.ReadLine()!);

        if (taskNumber > 3 || taskNumber < 1)
        {
            Console.WriteLine("There is no such task");
            return 0;
        }
        else
        {
            return taskNumber;
        }
    }
}



