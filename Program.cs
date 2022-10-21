
using ConsoleApp1;

internal class Program
{

    private static void Main(string[] args)
    {
        Console.Title = "skynet";
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WindowHeight = 40;
        
        Wizard wizard01 = new Wizard("Casper", "unexpecto patronum");
        Console.WriteLine("Write start to start the game:");
        string start = Console.ReadLine();

        if (start == "start")
        {
            if (wizard01.spellSlots < 0)
            {
                wizard01.Meditate();
            }
            else
            {
                wizard01.CastSpell();
            }
        }
        
        Console.ReadKey();
     

        
    }
}
