namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;
        string player;
        string computer;
        string answer;
        

        while (playAgain)
        {
            player = "";
            computer = "";

            while (player != "rock" && player != "paper" && player != "scissors")
            {
                Console.Write("enter rock, paper or scissors: ");
                player = Console.ReadLine();
            }
            switch (random.Next(1, 4))
            {
                case 1:
                    computer = "rock";
                    break;
                case 2:
                    computer = "paper";
                    break;
                case 3:
                    computer = "scissors";
                    break;
            }
            Console.WriteLine("player: " + player);
            Console.WriteLine("computer: " + computer);

            switch (player)
            {
                case "rock":
                    if(computer == "rock")
                    {
                        Console.WriteLine("it's a draw.");
                    }
                    else if (computer == "paper")
                    {
                        Console.WriteLine("you lose.");
                    }
                    else
                    {
                        Console.WriteLine("you win.");
                    }
                    break;
                case "paper":
                    if (computer == "paper")
                    {
                        Console.WriteLine("it's a draw.");
                    }
                    else if (computer == "scissors")
                    {
                        Console.WriteLine("you lose.");
                    }
                    else
                    {
                        Console.WriteLine("you win.");
                    }
                    break;
                case "scissors":
                    if (computer == "scissors")
                    {
                        Console.WriteLine("it's a draw.");
                    }
                    else if (computer == "draw")
                    {
                        Console.WriteLine("you lose.");
                    }
                    else
                    {
                        Console.WriteLine("you win.");
                    }
                    break;
                    
            }
            Console.WriteLine("would you like to play again? yes or no.");
            answer = Console.ReadLine();
            if(answer == "yes")
            {
                playAgain= true;
            }
            else
            {
                playAgain= false;
            }
        }
        Console.WriteLine("thanks for playing");
        Console.ReadKey();
        }
    }

