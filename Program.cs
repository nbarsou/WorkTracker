using System;

namespace WorkTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            System.Console.WriteLine("Welcome to TimeTrack");
            //Main menu UI 
            do{
                System.Console.WriteLine("Press <ESC> to exit .....");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.T: 
                        timeTrack();
                        break;
                    case ConsoleKey.N: 
                        //Create a New Task 
                        break;
                    case ConsoleKey.E: 
                        //Edit a Tasl
                        break; 
                    default: 
                        //Exeption Handeling
                        break; 
                    
                }
            }while(Console.ReadKey().Key != ConsoleKey.Escape);
        } 

        static void timeTrack(){ 
            // Start the TimeTrack 
            TimeSpan totalTime = TimeSpan.Zero;
            DateTime startTime = DateTime.Now; 
            Console.Clear();
            System.Console.WriteLine("TimeTrack Started at: {0:d} at {0:t}", startTime);

            // Option to Pause the TimeTrack or Stop 
            System.Console.WriteLine("[ENTER] to Stop       [P] to Pause");
            while(Console.ReadKey().Key != ConsoleKey.Enter){
                if(Console.ReadKey().Key == ConsoleKey.P){
                    // Stop the Time and add to totalTime
                    Console.Clear();
                    System.Console.WriteLine("TimeTrack Stoped at: {0:d} at {0:t}", DateTime.Now);
                    totalTime += DateTime.Now.Subtract(startTime);
                    System.Console.WriteLine("Total Time at: " + totalTime);
                    
                    // Resume the TimeTrack by reseting th startTime 
                    System.Console.WriteLine("Press [P] to Unpause the TimeTrack");
                    while(Console.ReadKey().Key != ConsoleKey.P){}
                    Console.Clear();
                    System.Console.WriteLine("TimeTrack Resumed at: {0:d} at {0:t}", DateTime.Now);
                    System.Console.WriteLine("[ENTER] to Stop       [P] to Pause");
                    startTime = DateTime.Now;
                }
            }
            // Get the Total Time 
            totalTime += DateTime.Now.Subtract(startTime);
            System.Console.WriteLine("Total Time Spent Workin : " + totalTime);
             
        }
    }
}
