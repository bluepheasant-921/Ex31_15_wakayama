using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex31_15
{
    class Tank : Character
    {
        public int bullet = 0;
        public Tank(string name, float hp, float power, bool animal, bool armor) : base(name, hp, power, animal,armor)
        {

        }
        public override void Attack(Character destination)
        {
            if (bullet > 0)
            {
                bullet--;
                Console.WriteLine($"\n{this.name}は{destination.name}に向け大砲を発射！");
                Console.WriteLine($"{destination.name}はうしろに吹っ飛んだ！");
                Console.WriteLine($"{destination.name}は{this.power}のダメージ");
                destination.hp -= this.power;
                Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
            }
            else
            {
                Console.WriteLine($"{base.name}は弾切れです！");
            }
        }
    }
}
