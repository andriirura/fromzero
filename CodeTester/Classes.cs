using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeTester
{
    public class RustPlayer : Object
    {
        public string Nick { get; private set; }
        public int Hp { get; private set; }
        public int Hunger { get; private set; }
        public int Hydration { get; private set; }

        public RustPlayer(string nick)
        {
            Nick = nick;
            Hp = 100;
            Hunger = 120;
        }


        public override string ToString()
        {
            string info = $"Nick={Nick} Hp={Hp} Hunger={Hunger} Hydration={Hydration}";
            return info;
        }

        public void Eat(FoodItem food)
        {
            Hp += food.HpBonus;
            Hunger += food.HungerBonus;
            Hydration += food.HydrationBonus;
        }
    }

    public abstract class FoodItem
    {
        public int HpBonus { get; set; }
        public int HydrationBonus { get; set; }
        public int HungerBonus { get; set; }
    }

    class Apple : FoodItem
    {
        public Apple()
        {
            HpBonus = 1;
            HungerBonus = 15;
            HydrationBonus = 10;
        }
    }
    class Pumpkin : FoodItem
    {
        public Pumpkin()
        {
            HpBonus = 5;
            HungerBonus = 100;
            HydrationBonus = 20;
        }
    }



    public class Classes
    {
        public static void Run()
        {
            var andrew = new RustPlayer("hophey");
            var cabron = new RustPlayer("Cabron");
            var nazik = new RustPlayer("fromHeroToZero");

            int number = 4;

            var allPlayers = new List<RustPlayer>
            {
                andrew,
                cabron,
                nazik
            };

           

            Console.WriteLine("Info about all players:");
            foreach (var item in allPlayers)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("========================");

            Console.WriteLine("After eating some food:");
            andrew.Eat(new Apple());
            cabron.Eat(new Pumpkin());

            cabron.Eat(new FoodItem());


            foreach (var item in allPlayers)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
