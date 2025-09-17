using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchexample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string pokemon;
            //string aboutpokemon = "";
            //Console.WriteLine("Choose first pokemon");
            //pokemon = Console.ReadLine();

            //switch (pokemon)
            //{
            //    case "Squirtle":
            //        aboutpokemon = "Type: Water";
            //        break;
            //    case "Bulbasaur":
            //        aboutpokemon = "Type: Grass, Poison";
            //        break;
            //    case "Charmander":
            //        aboutpokemon = "Type: Fire";
            //        break;
            //    default:
            //        aboutpokemon = "not a pokemon";
            //        break;
            //}

            //Console.WriteLine(aboutpokemon);


            int rating;
            Console.WriteLine("what is your rating? Out of 5");
            rating = int.Parse(Console.ReadLine());

            switch (rating)
            {
                case 0:
                    Console.WriteLine("Terrible!!");
                    Console.WriteLine("worst film ever");

                    break;
                case 5:
                    Console.WriteLine("Great!");
                    break;
                default:
                    Console.WriteLine("no rating");
                    break;

            }


        }
    }
}
