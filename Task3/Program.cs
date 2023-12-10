namespace Task3;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            var res = Game.Play(args);
            if(res==false) 
                break;
        }
    }
}
