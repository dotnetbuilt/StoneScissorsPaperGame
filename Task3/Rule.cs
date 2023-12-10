namespace Task3;

public static class Rule
{
    public static string CalculateWhoWin(int userMoveInd, int comMoveInd)
        =>  comMoveInd == userMoveInd ? "Draw" : comMoveInd < userMoveInd ? "You won!" : "You lost!";

    public static bool CheckUserMove(List<string> moves, string userMove)
        =>  moves.Contains(userMove);

    public static (bool, string) CheckCommandLineArgs(string[] args)
    {
        for(int i = 0; i < args.Length; i++)
            for(int j = 0;j<args.Length; j++)
            {
                if (i == j)
                    continue;

                if (args[i].Equals(args[j], StringComparison.OrdinalIgnoreCase))
                    return (false, $"{args[i]} and {args[j]} are same words!");
            }

        return (true, "");
    }
}