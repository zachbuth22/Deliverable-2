using System;

public class Program {
  public static void Main (string[] args) {
  
    Console.WriteLine("Welcome to the COIN FLIP CHALLENGE");

    Console.WriteLine("What is your name?:");
    string userName = Console.ReadLine();

    Console.WriteLine("Welcome " + userName + ". Do you want to do the COIN FLIP CHALLENGE? y/n");

    if (Console.ReadLine() == "y")
    {            
      Console.WriteLine("Great!");
    }else {Console.WriteLine("You are a coward " +userName);
      return;
      }

                {
               Random rnd = new Random();
            Console.WriteLine("Heads or Tails?");
            string headsOrTailsGuess = Console.ReadLine(); 
            Console.WriteLine("How many flips?");
            string NumberofFlips = Console.ReadLine();
            int CorrectCount;
            int flips = int.Parse(NumberofFlips); 
            int heads = 0; 
            int tails = 0; 

            for (int i=0; i< flips; i++) 
            {

                int num = rnd.Next(1,3); 

                if (num == 1) 
                {
                    heads++;
                    Console.WriteLine("heads");
                }
                else
                {
                    tails++;
                    Console.WriteLine("tails");
                }

            }
            if(headsOrTailsGuess[0]=='t'|| headsOrTailsGuess[0] == 'T') 
            {
                CorrectCount = flips - heads;
            }
            else
            {
                CorrectCount = flips - tails;
            }

            float Percentage = CorrectCount * 100 / flips; 

            Console.WriteLine("Thanks for playing " + userName + ". You got a score of " + CorrectCount +"! That is " + Percentage +"%");
        }
    
    
    
    
  }
}