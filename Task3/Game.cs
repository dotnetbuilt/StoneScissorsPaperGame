using System.Diagnostics.CodeAnalysis;

namespace Task3;

public static class Game
{
    public static void Exit()
    {
        Console.WriteLine("\tThe end!");
        Console.WriteLine();
        Environment.Exit(0);
    }

    

    public static bool Play(string[] args)
    {
        List<string> commands = ["x", "?"];

        Random rand = new Random();
        int comMoveInd = rand.Next(0, args.Length);
        string comMove = args[comMoveInd];

        const int NumberOfBits = 256;

        var key = Key.Generate(NumberOfBits);

        var hashBasedMessage = HMACGeneration.Generate(key, comMove);

        var hashBasedMessageAsString = Converter.ConvertFromByteToString(hashBasedMessage);

        var keyAsString = Converter.ConvertFromByteToString(key);

        Console.WriteLine($"\tHMAC: {hashBasedMessageAsString}");

        Console.WriteLine("\tAvailable moves:");

        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine($"\t[{i}] - {args[i]}");
            commands.Add($"{i}");
        }

        Console.WriteLine("\t[x] - exit");
        Console.WriteLine("\t[?] - help");

        Console.Write("Enter your move: ");
        dynamic? userMove = Console.ReadLine();

        var isValid = Rule.CheckUserMove(commands, userMove);
        if ( isValid == false)
        {
            Console.Write("\tEnter arguments like these: ");
            for (int i = 0; i < args.Length; i++)
                Console.Write($"{i}, ");

            Console.WriteLine("x, ?");
            Console.WriteLine();

            return true;
        }

        if (userMove == "x")
        {
            Exit();
        }
        else if (userMove == "?")
        {
            Table.ShowGraph(args);
            Console.WriteLine();
        }
        else
        {
            userMove = Convert.ToInt32(userMove);
            Console.WriteLine($"\tYour move: {args[userMove]}");

            Console.WriteLine($"\tComputer move: {comMove}");

            var result = Rule.CalculateWhoWin(userMove, comMoveInd);

            Console.WriteLine('\t' + result);

            Console.WriteLine($"\tHMAC key: {keyAsString}");
        }
        Console.WriteLine();

        return true;
    }
}
