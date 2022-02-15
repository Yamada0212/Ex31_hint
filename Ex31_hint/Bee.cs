using System;
using System.Collections.Generic;
using System.Text;

namespace Ex31_hint
{
    class Bee:Character
    {
        public Bee(string name, float hp, float power,float skin) : base(name, hp, power,skin) { }
        public override void Attack(Character destination)
        {
          Console.WriteLine($"{this.name}は{destination.name}に「毒針」！");
            if (destination.skin==0)
            {
                destination.hp -= destination.hp;
                Console.WriteLine($"{destination.name}は死んでしまった！！");
            }
            else
            {
                Console.WriteLine($"{destination.name}は{this.power}のダメージ");
                destination.hp -= this.power;
                Console.WriteLine($"{destination.name}の残りのHPは{destination.hp}");
            }
             
            
        }
    }
}
