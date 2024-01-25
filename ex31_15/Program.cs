using System.Threading.Tasks;

namespace ex31_15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Character character1 = new Character("しむら人", 1000, 2, true, true);
            Character character2 = new Character("ささっき", 1000, 25, true, false);
            Tank tank1 = new Tank("Tiger", 500000, 250, false, true);
            tank1.bullet = 10;
            Tank tank2 = new Tank("がんタンク", 10000, 125, false, true);
            tank2.bullet = 5;
            Cat cat1 = new Cat("野良猫", 500, 15, true, false);
            Cow cow1 = new Cow("黒毛和牛", 4, 50, true, false);
            Cow cow2 = new Cow("闘牛", 3000, 75, true, false);
            Hornet hornet1 = new Hornet("スズメバチ", 250, 40, true, false);
            Character[] characters = { character1, character2, tank1, tank2, cat1, cow1, cow2, hornet1 };
            for (var i = 1; i < characters.Length; i++)
            {
                characters[i].Attack(character1);
            }
            characters[7].Attack(tank1);
            characters[7].Attack(character2);
        }
    }
}