using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    class Cow : Character
    {
        public float Cowhp = 5;
        public Cow(string name, float hp, float power,float skin) : base(name, hp, power,skin) { }

        public override void Attack(Character destination)
        {
            if (this.hp >= destination.hp)
            {
                Console.WriteLine($"{this.name}は{destination.name}に「角で突く」!");
                Console.WriteLine($"{destination.name}は{this.power}のダメージ");
                destination.hp -= this.power;
                Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
                this.hp -= -10;
            }
            else
            {
                Console.WriteLine("HPが少なくて攻撃できません");
            }
        }
    }
}
