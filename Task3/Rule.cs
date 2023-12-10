namespace Task3;

public static class Rule
{
    public static string CalculateWhoWin(int userMoveInd, int comMoveInd)
    {
        if(userMoveInd == comMoveInd)
        {
            Game.comScore += 1;
            Game.userScore += 1;
            Game.numberOfDraws += 1;
            return "Draw!";
        }
        else if(userMoveInd < comMoveInd)
        {
            Game.comScore += 2;
            Game.numberOfDefeats += 1;
            return "You lost!";
        }
        else
        {
            Game.userScore += 2;
            Game.numberOfVictories += 1;
            return "You won!";
        }
    }

    public static bool CheckUserMove(List<string> moves, string userMove)
    => moves.Contains(userMove);

    public static (bool, string) CheckIfArgsRepeating(string[] args)
    {
        for (int i = 0; i < args.Length; i++)
            for (int j = 0; j < args.Length; j++)
            {
                if (i == j)
                    continue;

                if (args[i].Equals(args[j], StringComparison.OrdinalIgnoreCase))
                    return (false, $"{args[i]} and {args[j]} are same words!Arguments need to be non-repeating!");
            }

        return (true, "");
    }

    public static (bool, string) CheckArgsNumber(string[] args)
    {
        var error = $"Number of arguments must be equal or greater than 3." +
                    $"It must be odd.";
        return args.Length >= 3 && args.Length % 2 != 0
           ? (true, "")
           : (false, error);
    }

    public static bool CheckEveryArg(string[] args)
    {
        return args.All(arg => arg.Length >=4);
    }
}