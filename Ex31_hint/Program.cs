using System;

namespace Ex31_hint
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character1 = new Character("しむら人", 500, 2,0);
            Character character2 = new Character("ささっき", 1000, 25,0);
            Tank tank1 = new Tank("Tiger", 500000, 250,100);
            tank1.bullet = 10;
            Tank tank2 = new Tank("がんタンク", 10000, 125,100);
            tank2.bullet = 5;
            Cow cow = new Cow("牛", 100, 20,30);
            Cat cat = new Cat("猫", 10, 5,7);
            Bee bee = new Bee("蜂", 1, 20,6);
            Character[] characters = { character1, character2, tank1, tank2,cow,cat,bee};
            for(var i = 1; i < characters.Length; i++)
            {
                characters[i].Attack(character1);
            }
        }
    }
}
