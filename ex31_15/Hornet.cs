using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex31_15
{
    class Hornet : Animal
    {

        public Hornet(string name, float hp, float power, bool animal) : base(name, hp, power, animal)
        {

        }


        public override void Attack(Character destination)
        {
            bool animalJudge = destination.AnimalJudge;
            if (animalJudge)
            {
                Console.WriteLine($"{this.name}は{destination.name}に毒針を刺した(動物は即死)！");
                Console.WriteLine($"{destination.name}は{destination.hp}のダメージ");
                destination.hp -= destination.hp;
                Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
            }
            else
            {
                Console.WriteLine($"{this.name}は{destination.name}に毒針を刺した(動物は即死)！");
                Console.WriteLine($"{destination.name}は{this.power}のダメージ");
                destination.hp -= this.power;
                Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");


            }
        }
    }
}
