namespace Task3;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            var numberOfArgs = Rule.CheckArgsNumber(args);
            if(numberOfArgs.Item1 == false)
            {
                Console.WriteLine($"\t[{numberOfArgs.Item2}]");
                break;
            }

            var ifArgsRepeating = Rule.CheckIfArgsRepeating(args);
            if(ifArgsRepeating.Item1 == false)
            {
                Console.WriteLine($"\t[{ifArgsRepeating.Item2}]");
                break;
            }

            var res = Game.Play(args);
            if(res==false) 
                break;
        }
    }
}
