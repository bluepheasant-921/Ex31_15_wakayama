using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex31_15
{
    class Hornet : Animal
    {

        public Hornet(string name, float hp, float power, bool animal, bool armor) : base(name, hp, power, animal, armor)
        {

        }


        public override void Attack(Character destination)
        {
            bool animalJudge = destination.AnimalJudge;
            bool armorJudge = destination.ArmorJudge;
            if (animalJudge)
            {
                if (armorJudge)
                {
                    Console.WriteLine($"\n{this.name}は{destination.name}に毒針を刺した！");
                    Console.WriteLine($"{destination.name}は動物だ！しかし、{destination.name}は硬くて針がしっかり刺さらなかった");
                    Console.WriteLine($"{destination.name}は{this.power}のダメージ");
                    destination.hp -= this.power;
                    Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
                }
                else
                {
                    PoisonAttack(destination, "毒針を刺した");
                }
            }
            else
            {
                if (armorJudge)
                {
                    Console.WriteLine($"\n{this.name}は{destination.name}に毒針を刺した！");
                    Console.WriteLine($"しかし硬すぎて刺さらなかった");
                    Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
                }
                else
                {
                    Console.WriteLine($"\n{this.name}は{destination.name}に毒針を刺した！");
                    Console.WriteLine($"{destination.name}は{this.power}のダメージ");
                    destination.hp -= this.power;
                    Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
                }

            }
        }
    }
}
