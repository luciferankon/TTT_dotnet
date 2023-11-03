using System;
namespace TTT_dotnet
{
    // Constants.cs
    internal static class Constants
    {
        public static List<List<int>> winningCombinations = new List<List<int>>
        {
            new List<int> {1, 2, 3},
            new List<int> {4, 5, 6},
            new List<int> {7, 8, 9},
            new List<int> {1, 4, 7},
            new List<int> {2, 5, 8},
            new List<int> {3, 6, 9},
            new List<int> {1, 5, 9},
            new List<int> {3, 5, 7},
        };
    }

}

