namespace Task3;

public static class Rule
{
    public static string CalculateWhoWin(int userMoveInd, int comMoveInd)
        =>  comMoveInd == userMoveInd ? "Draw" : comMoveInd < userMoveInd ? "You won!" : "You lost!";

    public static bool CheckUserMove(List<string> moves, string userMove)
        =>  moves.Contains(userMove);
}
