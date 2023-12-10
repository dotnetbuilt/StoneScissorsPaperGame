namespace Task3;

public static class Rule
{
    public static string CalculateWhoWin(int userMoveInd, int comMoveInd)
    {
        if (comMoveInd == userMoveInd)
            return "Draw!";
        else if (comMoveInd < userMoveInd)
            return "You won!";
        
        return "You lost!";
    }

    public static bool CheckUserMove(List<string> moves, string userMove)
    {
        return moves.Contains(userMove);
    }
}
