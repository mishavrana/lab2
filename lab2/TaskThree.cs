class TaskThree {
    
    int answer = 0;
    public void Calculate() {
		
		while (true) {
			int num = new UserData().AskToEnter();
			if (num < 20) {
				Console.WriteLine("Wrong number format");
			} else {
				for (int i = 21; i <= num; i++) {
					answer += i - 4;
				}
				answer += 8;
				Console.WriteLine(answer);
				break;
			}
		}
	}
}