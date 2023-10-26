using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTraderProject
{
    class MainMenu
    {
        public BuyMenu buyMenu = new BuyMenu();
        public SellMenu sellMenu = new SellMenu();
        public ShipGarage shipGarage = new ShipGarage();
        public Travel travel = new Travel();
        static public double userMoney = 1000000;
        static public double userCurrentCargo = 0;
        static public double userMaxCargo = 50;
        static public int MaxFuel = 10;
        static public int ShipSpeed = 1;
        static public double goldCargo = 0;
        static public double silverCargo = 0;
        static public double titaniumCargo = 0;

      



        //hub for user

        public void DisplayMenu()
        {           
            

            do
            {
                Console.Clear();
                MenuInstructions();
                try
                { 
                    int userSelection = int.Parse(Console.ReadLine());
                    switch (userSelection)
                    {                
                    case 1:
                            buyMenu.BoughtItems();                       
                            break;

                    case 2:
                            sellMenu.SoldItems();                        
                            break;

                    case 3:
                            shipGarage.DisplayGarage();                       
                            break;

                    case 4:
                            travel.DisplayPlanets();
                            break;

                    case 5:
                            return;

                    default:
                            Console.WriteLine("Invalid Input");
                            break;
                }
                }
                catch (System.FormatException)
                {

                    Console.WriteLine("Please enter one of the options displayed to you");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                }

            } while (true);

        }

        public void MenuInstructions()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("Type 1 to buy");
            Console.WriteLine("Type 2 to sell");
            Console.WriteLine("Type 3 for SpaceShip Upgrade ");
            Console.WriteLine("Type 4 to travel");
            Console.WriteLine("Type 5 to exit game");
        }

        

        
    }

    
}
