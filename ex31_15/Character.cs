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
        readonly private bool armorJudge;

        public bool AnimalJudge
        {
            get { return animalJudge; }
        }
        public bool ArmorJudge
        {
            get { return armorJudge; }
        }
        public Character(string name, float hp, float power, bool animal,bool armor)
        {
            this.name = name;
            this.hp = hp;
            this.power = power;
            this.animalJudge = animal;
            this.armorJudge = armor;
        }
        public virtual void Attack(Character destination)
        {
            Console.WriteLine($"\n{this.name}は{destination.name}をぶんなぐった！");
            Console.WriteLine($"{destination.name}は{this.power}のダメージ");
            destination.hp -= this.power;
            Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
        }
        public void PoisonAttack(Character destination,string attackMessage)
        {
            Console.WriteLine($"\n{this.name}は{destination.name}に{attackMessage}！");
            Console.WriteLine($"{destination.name}は動物だ！\n{destination.hp}のダメージ");
            destination.hp -= destination.hp;
            Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
        }
    }
}
