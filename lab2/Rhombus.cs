class Rhombus {
    char symbol;
    public void MainProcess(){

     ChooseSymbol();
     Console.WriteLine(" ");
     DrawSymbol();


    }
    private void ChooseSymbol(){
        while(true) {
            Console.WriteLine("Choose Symbol");
            int numberOfSymbol = int.Parse(s: Console.ReadLine()!);
            switch (numberOfSymbol) {
                case 1: 
                symbol = '*';
                break;
                case 2: 
                symbol = '#';
                break;
                case 3: 
                symbol = '$';
                break;
            }
            break;
        }
    }

    private void DrawSymbol(){
        
        // int height = int.Parse(Console.ReadLine()!);
        // int width = int.Parse(Console.ReadLine()!);

        int height = 10;
        int width = 10;

        

        int top = Console.CursorTop;
        int middle = Console.CursorLeft + width;

        int y1 = top;
        int x1 = middle;
        
        Console.SetCursorPosition(x1, y1);
        Console.WriteLine(symbol);

        // UpRight
        for(int i = 0; i < height / 2; i++){
            Console.SetCursorPosition(x1--, y1++);
            Console.WriteLine(symbol);
            
        }
        //DownRight
        for(int i = 0; i < height / 2; i++){
            Console.SetCursorPosition(x1 ++, y1++);
            Console.WriteLine(symbol);
            
        }

         //DownLeft
        for(int i = 0; i < height / 2; i++){
            Console.SetCursorPosition(x1++, y1--);
            Console.WriteLine(symbol);
        }

        


       

       
    }
}