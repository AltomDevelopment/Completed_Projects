using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTraderProject
{
    class SpaceShips
    {
        public SpaceShips()
        {

        }
        //allow user to upgrade ships
        public void TryIntermediateSpaceshipPurchase(int cost)
        {
            if (MainMenu.userMoney > cost)
            {
                MainMenu.userMoney -= cost;
                MainMenu.userMaxCargo = 100;
                MainMenu.MaxFuel = 25;
                Console.WriteLine("You purchased this ship for $" + cost);
                Console.WriteLine("You now have $" + MainMenu.userMoney);
                Console.WriteLine("You now have a cargo capacity of: " + MainMenu.userMaxCargo);
                Console.WriteLine("Your max fuel is now: " + MainMenu.MaxFuel);
                Console.WriteLine("");
                ChooseSpeedIntermediate();              
            }
            else
            {
                Console.WriteLine("You don't have enough money to purchase this ship!");
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();
            }
        }

        public void TryAdvancedSpaceshipPurchase(int cost)
        {
            if (MainMenu.userMoney > cost)
            {
                MainMenu.userMoney -= cost;
                MainMenu.userMaxCargo = 150;
                MainMenu.MaxFuel = 50;
                Console.WriteLine("You purchased this ship for $" + cost);
                Console.WriteLine("You now have $" + MainMenu.userMoney);
                Console.WriteLine("You now have a cargo capacity of: " + MainMenu.userMaxCargo);
                Console.WriteLine("Your max fuel is now: " + MainMenu.MaxFuel);
                Console.WriteLine("");
                ChooseSpeedAdvanced();
            }
            else
            {
                Console.WriteLine("You don't have enough money to purchase this ship!");
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();
            }
        }

        public int exitLoop = 0;
        public void ChooseSpeedBasic()
        {
            do
            {
                Console.WriteLine("Select a speed for your SpaceShip");
                Console.WriteLine("Speed must be between 1 and 4");
                int selectedSpeed = int.Parse(Console.ReadLine());
                if (selectedSpeed > 0 && selectedSpeed <= 4)
                {
                    exitLoop += 1;
                    MainMenu.ShipSpeed = selectedSpeed;
                    Console.Clear();
                    Console.WriteLine("Your ship now has a speed of: " + selectedSpeed);
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("You can't choose that speed");
                    Console.WriteLine("Press 'Enter' to continue");
                    Console.ReadLine();
                }
            } while (exitLoop == 0);
        }

        public int exitLoop1 = 0;
        public void ChooseSpeedIntermediate()
        {
            do
            {
                 Console.WriteLine("Select a speed for your SpaceShip");
                 Console.WriteLine("Speed must be between 1 and 6");
                 int selectedSpeed = int.Parse(Console.ReadLine());
                 if (selectedSpeed > 0 && selectedSpeed <= 6)
                 {
                     exitLoop1 += 1;
                     MainMenu.ShipSpeed = selectedSpeed;
                     Console.Clear();
                     Console.WriteLine("Your ship now has a speed of: " + selectedSpeed);
                     Console.WriteLine("Press 'Enter' to continue");
                     Console.ReadLine();
                 }
                 else
                 {
                     Console.WriteLine("You can't choose that speed");
                     Console.WriteLine("Press 'Enter' to continue");
                     Console.ReadLine();
                 }
            } while (exitLoop1 == 0);
        }

        public int exitLoop2 = 0;
        public void ChooseSpeedAdvanced()
        {
            do
            {
                  Console.WriteLine("Select a speed for your SpaceShip");
                  Console.WriteLine("Speed must be between 1 and 9");
                  int selectedSpeed = int.Parse(Console.ReadLine());
                  if (selectedSpeed > 0 && selectedSpeed <= 9)
                  {
                      exitLoop2 += 1;
                      MainMenu.ShipSpeed = selectedSpeed;
                      Console.Clear();
                      Console.WriteLine("Your ship now has a speed of: " + selectedSpeed);
                      Console.WriteLine("Press 'Enter' to continue");
                      Console.ReadLine();
                  }
                  else
                  {
                      Console.WriteLine("You can't choose that speed");
                      Console.WriteLine("Press 'Enter' to continue");
                      Console.ReadLine();
                  }
            } while (exitLoop2 == 0);
        }
    }
}
