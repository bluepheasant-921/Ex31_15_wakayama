using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex31_15
{
    class Cat : Animal
    {
        public Cat(string name, float hp, float power, bool animal, bool armor) : base(name, hp, power, animal,armor)
        {

        }

        public override void Attack(Character destination)
        {
            Console.WriteLine($"\n{this.name}は{destination.name}をひっかいた！");
            Console.WriteLine($"{destination.name}は{this.power}のダメージ");
            destination.hp -= this.power;
            Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
        }
    }
}
