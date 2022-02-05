class TaskOne {
    public void Calculate()
    {
        
        int num = new UserData().AskToEnter();
        

        if (num >= 6)
        {
            Console.WriteLine("Wrong number format");
            return;
        }
        else
        {
            Console.WriteLine (
                Math.Round(Convert.ToDouble (
                    Math.Pow(num, 5) / 5 + 17.0 / 21.0),
                    2)
                );
        }
    }
}
