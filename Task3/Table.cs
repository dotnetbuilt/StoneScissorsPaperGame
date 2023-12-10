namespace Task3;

public static class Table
{
    private static readonly string verticalBar = "|";
    private static readonly string backslashT = "\t";
    private static readonly string whiteSpace = " ";
    private static readonly int whiteSpaceLen = whiteSpace.Length;

    public static void ShowGraph(string[] args)
    {
        var draw = (Result.Draw).ToString();
        var lose = (Result.Lose).ToString();
        var win = (Result.Win).ToString();
        var fstRFstC = $"Example >";
        List<int> colLens = [];

        ConsoleWritePlusMinus(args, fstRFstC);

        Console.Write($"{backslashT}{verticalBar}");
        Console.Write($"{whiteSpace}{fstRFstC}{whiteSpace}");
        foreach (string arg in args)
        {
            Console.Write(verticalBar);
            var fstRArg = $"{arg}";
            colLens.Add(fstRArg.Length);
            Console.Write($"{whiteSpace}{fstRArg}{whiteSpace}");
        }
        Console.WriteLine(verticalBar);

        for (int j = 0; j < args.Length; j++)
        {
            ConsoleWritePlusMinus(args, fstRFstC);

            Console.Write($"{backslashT}{verticalBar}");
            Console.Write($"{whiteSpace}{args[j]}");

            ConsoleWriteWhiteSpace(fstRFstC.Length, args[j].Length);

            for (int i = 0; i < args.Length; i++)
            {
                var difference = j - i;
                switch (difference)
                {
                    case 0:
                        Console.Write(verticalBar);
                        Console.Write($"{whiteSpace}{draw}");
                        ConsoleWriteWhiteSpace(colLens[i], draw.Length);
                        break;
                    case < 0:
                        Console.Write(verticalBar);
                        Console.Write($"{whiteSpace}{lose}");
                        ConsoleWriteWhiteSpace(colLens[i], lose.Length);
                        break;
                    case > 0:
                        Console.Write(verticalBar);
                        Console.Write($"{whiteSpace}{win}");
                        ConsoleWriteWhiteSpace(colLens[i], win.Length);
                        break;
                }
            }
            Console.WriteLine(verticalBar);
        }
        ConsoleWritePlusMinus(args, fstRFstC);
    }

    public static void ConsoleWriteWhiteSpace(int firstRawLen, int argumentLen)
    {
        for (int k = 1; k <= whiteSpaceLen * (firstRawLen + whiteSpaceLen * 2 - (whiteSpaceLen + argumentLen)); k++)
        {
            Console.Write(whiteSpace);
        }
    }

    public static void ConsoleWritePlusMinus(string[] args, string fstRFstC)
    {
        var plus = "+";
        var minus = "-";

        Console.Write($"{backslashT}{plus}");
        for (int i = 0; i < fstRFstC.Length + whiteSpaceLen * 2; i++)
        {
            Console.Write(minus);
        }
        Console.Write(plus);

        for (int p = 0; p < args.Length; p++)
        {
            for (int k = 0; k < minus.Length * (args[p].Length + whiteSpaceLen * 2); k++)
            {
                Console.Write(minus);
            }
            Console.Write(plus);
        }
        Console.WriteLine();
    }
}
