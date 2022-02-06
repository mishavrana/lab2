class TaskTwo
{
	double answer = 1;
    public void Calculate() {
		
		while (true) {
			int num = new UserData().AskToEnter();
			if (num < 6 || num > 20) {
				Console.WriteLine("Wrong number format");
			} else {
				for (int i = 6; i <= num; i++) {
					answer *= Convert.ToDouble(Math.Pow(i, 2)) / 2;
				}
				answer *= 4;
				Console.WriteLine(
					Math.Round(answer, 2)
				);
				break;
			}
		}
	}
}

