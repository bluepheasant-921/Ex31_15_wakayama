using System.Threading.Tasks;

namespace ex31_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a");
            Character character1 = new Character("しむら人", 500, 2, true);
            Character character2 = new Character("ささっき", 1000, 25, true);
            Tank tank1 = new Tank("Tiger", 500000, 250, false);
            tank1.bullet = 10;
            Tank tank2 = new Tank("がんタンク", 10000, 125, false);
            tank2.bullet = 5;
            Character[] characters = { character1, character2, tank1, tank2 };
            for (var i = 1; i < characters.Length; i++)
            {
                characters[i].Attack(character1);
            }
        }
    }
}