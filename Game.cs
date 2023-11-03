using System;
namespace TTT_dotnet
{
	public class Game
	{
		private List<string> board;
		private List<Player> players;

		public Game(List<string> board, List<Player> players)
		{
			this.board = board;
			this.players = players;
		}

		public Player GetCurrentPlayer()
		{
			return this.players.First();
		}

		public Player GetLastPlayer()
		{
			return this.players.Last();
		}

		public void MakeMove(int move)
		{
            Player currentPlayer = this.GetCurrentPlayer();
			currentPlayer.MakeMove(move);
			board[move - 1] = currentPlayer.GetSymbol();
            this.players = this.players.Skip(1).Concat(this.players.Take(1)).ToList();
        }

		public Boolean IsGameOver()
		{
            Player currentPlayer = this.GetLastPlayer();
			return Constants.winningCombinations.Any(currentPlayer.HasWon) || this.IsDraw();
		}

        public bool IsDraw()
        {
			return this.board.Where(pos => !string.IsNullOrEmpty(pos)).ToList().Count() == 9;
        }
    }
}

