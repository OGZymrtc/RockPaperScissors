using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] option ={"rock","paper","scissors"};
            //{playerA, playerB, tie}
            int[] winCounter={0,0,0}; 
            Random random =new Random();
            for(int i=0; i<100;i++){
                switch(option[random.Next(3)]){
                    case "rock":
                    winCounter[0]++;
                    break;
                    case "paper":
                    winCounter[2]++;
                    break;
                    case "scissors":
                    winCounter[1]++;
                    break;
                }
            }
            Console.WriteLine("Player A wins "+winCounter[0]+" of 100 games\nPlayer B wins "+winCounter[1]+" of 100 games\nTie: "+winCounter[2]+" of 100 games");
        }
    }
}
