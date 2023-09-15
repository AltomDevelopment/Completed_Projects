using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTraderProject
{
    class ShipGarage
    {
        
        SpaceShips newShip = new SpaceShips();
        //store ship stats 
        public void DisplayGarage()
        {
                      
            DisplayInstructions();
            int userSelection = int.Parse(Console.ReadLine());
            
                switch (userSelection)
                {
                    case 1:
                        newShip.TryIntermediateSpaceshipPurchase(18000);                   
                        break;

                    case 2:
                        newShip.TryAdvancedSpaceshipPurchase(100000);
                        break;

                    case 3:
                        newShip.ChooseSpeedBasic();
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            
           
            
        }

        public void DisplayInstructions()
        {
            Console.Clear();
            string[] instructions = {"Pick a ship to buy!", " ",
                                     "Type 1 for Intermediate",
                                     "Cost: $18000, Max Speed:6, Max Cargo:100, Max Fuel:25", " ",
                                     "Type 2 for Advanced",
                                     "Cost: $100000, Max Speed:9, Max Cargo:150, Max Fuel:50", " ",
                                     "Type 3 to change the speed of your basic ship"};
            foreach (string line in instructions)
            {
                Console.WriteLine(line);
            }
        }
    }
}
