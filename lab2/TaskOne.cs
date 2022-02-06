class TaskOne {

    double answer;
    public void Calculate()
    {
        while (true) {
            int num = new UserData().AskToEnter();
        

            if (num >= 6)
            {
             Console.WriteLine("Wrong number format");
            }
            else
            {
                answer = Convert.ToDouble (Math.Pow(num, 5) / 5 + 17.0 / 21.0);
                Console.WriteLine (
                    Math.Round(answer,2)
                    );
                break;
            }
        }
        
    }
}
