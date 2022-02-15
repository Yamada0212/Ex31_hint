using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    class Cat:Character
    {
        public Cat(string name, float hp, float power ,float skin) : base(name, hp, power,skin) { }

        public override void Attack(Character destination)
        {
                Console.WriteLine($"{this.name}は{destination.name}に「爪でひっかく」！");
                Console.WriteLine($"{destination.name}は{this.power}のダメージ");
                destination.hp -= this.power;
                Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
        }
    }
}
