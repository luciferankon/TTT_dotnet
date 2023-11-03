using System;
namespace TTT_dotnet;

class Program
{
    public static void Main(string[] args)
    {
        List<string> board = new List<string>(new string[9]);
        Player playerX = new Player("X");
        Player playerY = new Player("Y");
        List<Player> players = new List<Player> { playerX, playerY };
        Game game = new Game(board, players);

        while(!game.IsGameOver())
        {
            Console.WriteLine($"Play next move for player {game.GetCurrentPlayer().GetSymbol()}");
            string? move = Console.ReadLine();
            game.MakeMove(int.Parse(move));
        }

        if (game.IsDraw())
        {
            Console.WriteLine("Game is draw");
            return;
        }
        Console.WriteLine($"Winner is {game.GetLastPlayer().GetSymbol()}");
    }
}

