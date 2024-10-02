using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTraderProject
{
    class Travel
    {
        public static Planets currentPlanet;

        public void DisplayPlanets()
        {
            Console.Clear();
            Planets[] Planet = new Planets[8];
            Planet[0] = new Planets("Earth", 0, 0);
            Planet[1] = new Planets("Pluto", 15, 20);
            Planet[2] = new Planets("Uranus", -10, -10);
            Planet[3] = new Planets("Planet Hollywood", 35, 30);
            Planet[4] = new Planets("Happy Planet", 100, -75);
            Planet[5] = new Planets("Alpha Centauri", 5, -10);
            Planet[6] = new Planets("M63", 16, 3);
            Planet[7] = new Planets("P34", -9, 6);

            currentPlanet = Planet[0];

            Console.WriteLine("Your current planet is : " + currentPlanet.PlanetName());
            Console.WriteLine("");
            Console.WriteLine("Type the number of the planet you want to go to");
            Console.WriteLine("");

            Console.WriteLine("1  " + Planet[0].PlanetName());
            Console.WriteLine("2  " + Planet[1].PlanetName());
            Console.WriteLine("3  " + Planet[2].PlanetName());
            Console.WriteLine("4  " + Planet[3].PlanetName());
            Console.WriteLine("5  " + Planet[4].PlanetName());
            Console.WriteLine("6  " + Planet[5].PlanetName());
            Console.WriteLine("7  " + Planet[6].PlanetName());
            Console.WriteLine("8  " + Planet[7].PlanetName());
            int travelChoice = int.Parse(Console.ReadLine());

            switch (travelChoice)
            {
                case 1:
                    currentPlanet = Planet[0];
                    break;
                case 2:
                    currentPlanet = Planet[1];
                    //A new random has to be made for each planet so the prices change
                    Random srt = new Random();
                    SellMenu.goldPrice = srt.Next(100, 1001);
                    SellMenu.silverPrice = srt.Next(100, 1001);
                    SellMenu.titaniumPrice = srt.Next(100, 1001);
                    break;
                case 3:
                    currentPlanet = Planet[2];
                    break;
                case 4:
                    currentPlanet = Planet[3];
                    break;
                case 5:
                    currentPlanet = Planet[4];
                    break;
                case 6:
                    currentPlanet = Planet[5];
                    break;
                case 7:
                    currentPlanet = Planet[6];
                    break;
                case 8:
                    currentPlanet = Planet[7];
                    break;
                default:
                    Console.WriteLine("You did not choose a correct planet");
                    break;
            }
        } 
        
        
    }
}
