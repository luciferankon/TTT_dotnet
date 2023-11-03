using System;
namespace TTT_dotnet
{
	public class Player
	{
		private List<int> moves;
		private string symbol;


        public Player(string symbol)
		{
			this.symbol = symbol;
			this.moves = new List<int>();
		}

		public void MakeMove(int move)
		{
            this.moves.Add(move);
        }

		public string GetSymbol()
		{
			return this.symbol;
		}

		public Boolean HasWon(List<int> moveset)
		{
            return moveset.All(move => this.moves.Contains(move));
		}
	}
}

