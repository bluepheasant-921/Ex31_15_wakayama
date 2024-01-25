using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex31_15
{
    class Cow : Animal
    {
        public Cow(string name, float hp, float power, bool animal, bool armor) : base(name, hp, power, animal, armor)
        {

        }
        public override void Attack(Character destination)
        {
            if (hp >= 5)
            {
                Console.WriteLine($"\n{this.name}は{destination.name}に角で突く攻撃！");
                Console.WriteLine($"{destination.name}は{this.power}のダメージ");
                destination.hp -= this.power;
                Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
            }
            else
            {
                Console.WriteLine($"\n{base.name}は体力が少なくて角で突けなかった！");
            }
        }
    }
}
