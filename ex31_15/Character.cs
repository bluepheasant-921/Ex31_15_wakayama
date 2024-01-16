using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex31_15
{
    class Character
    {
        readonly public string name;
        public float hp;
        protected float power;
        readonly private bool animalJudge;

        public bool AnimalJudge
        {
            get { return animalJudge; }
        }
        public Character(string name, float hp, float power, bool animal)
        {
            this.name = name;
            this.hp = hp;
            this.power = power;
            this.animalJudge = animal;
        }
        public virtual void Attack(Character destination)
        {
            Console.WriteLine($"{this.name}は{destination.name}をぶんなぐった！");
            Console.WriteLine($"{destination.name}は{this.power}のダメージ");
            destination.hp -= this.power;
            Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
        }
    }
}
