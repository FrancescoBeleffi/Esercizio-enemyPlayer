
using BlaisePascal.EsercizioEnemy.Domain;
using BlaisePascal.EserczioEnemy.Domain;
using System;
using System.Numerics;

namespace BlaisePascal.EsercizioEnemy.Console
{

    namespace BlaisePascal.EsercizioEnemy.Console
    {
        public class Program
        {

            public static void Main()
            {
                Player player = new Player("Player");
                try
                {
                    player.AddGold(-500);
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
                try
                {
                    player.Heal(-100);
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
                /*try 
                {
                    player.AddExperience(99);
                    player.AddExperience(156);
                    //player.AddExperience(-500); //To verify
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
                */
                try
                {
                    player.TakeDamage(-1);
                }
                catch (Exception ex) { Console.WriteLine(ex.Message); }
            }
        }
    }
}


