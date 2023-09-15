using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTraderProject
{
    class BuyMenu
    {

        public BuyMenu()
        {

        }
  
        public void DisplayInventory()
        {
            //display goods to purchase
            Console.Clear();
            Console.WriteLine("What would you like to buy?"); 
            Console.WriteLine("Type 1 for Gold");                  
            Console.WriteLine("Type 2 for Silver");
            Console.WriteLine("Type 3 for Titanium");
            Console.WriteLine("Type 4 for Main Menu");
            Console.WriteLine(" ");
            string itemList = "Gold"     + "   " + "$" + (SellMenu.goldPrice)   + "\n" +
                              "Silver"   + "   " + "$" + (SellMenu.silverPrice) + "\n" +
                              "Titanium" + "   " + "$" + (SellMenu.titaniumPrice);
   
            Console.WriteLine(itemList);
                
            
        }
        //apply math based on user selection
        public void BoughtItems()
        {
            do
            {
                DisplayInventory();
                try
                {
                int userSelection = int.Parse(Console.ReadLine());
                switch (userSelection)
                {
                    case 1:                        
                       Console.Clear();
                       MoneySubtraction(SellMenu.goldPrice);
                       AddGoldCargo();
                       DisplayNewStats(MainMenu.goldCargo);
                        break;

                    case 2:           
                       Console.Clear();
                       MoneySubtraction(SellMenu.silverPrice);
                       AddSilverCargo();
                       DisplayNewStats(MainMenu.silverCargo);
                         break;

                    case 3:            
                       Console.Clear();
                       MoneySubtraction(SellMenu.titaniumPrice);
                       AddTitaniumCargo();
                       DisplayNewStats(MainMenu.titaniumCargo);
                         break;

                    case 4:            
                        return;             
 
                    default:
                       Console.WriteLine("Invalid input. Please make a selection");
                        break;
                }
            }
                catch (System.FormatException)
            {

                Console.WriteLine("Please enter one of the options displayed to you");
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();
            }
        } while (true) ;
        }

        public void MoneySubtraction(int i)
        {
            if (MainMenu.userMoney < i)
            {
                Console.WriteLine("You don't have enough money to buy this item");
                Console.WriteLine("Press 'Enter' to continue");
                Console.ReadLine();
            }
            else
            {
                MainMenu.userMoney -= i;
            }
            
        }

        public double AddGoldCargo()
        {
            if (MainMenu.userCurrentCargo < MainMenu.userMaxCargo)
            {
                MainMenu.goldCargo += 1;
                MainMenu.userCurrentCargo += 1;
                return MainMenu.goldCargo;
            }
            else
            {
                Console.WriteLine("Not enough cargo space");
                return MainMenu.goldCargo;
            }
        }

        public double AddSilverCargo()
        {
            if (MainMenu.userCurrentCargo < MainMenu.userMaxCargo)
            {
                MainMenu.silverCargo += 1;
                MainMenu.userCurrentCargo += 1;
                return MainMenu.silverCargo;
            }
            else
            {
                Console.WriteLine("Not enough cargo space");
                return MainMenu.silverCargo;
            }
        }

        public double AddTitaniumCargo()
        {
            if (MainMenu.userCurrentCargo < MainMenu.userMaxCargo)
            {
                MainMenu.titaniumCargo += 1;
                MainMenu.userCurrentCargo += 1;
                return MainMenu.titaniumCargo;
            }
            else
            {
                Console.WriteLine("Not enough cargo space");
                return MainMenu.titaniumCargo;
            }
        }

        public void DisplayNewStats(double cargo)
        {
            Console.WriteLine("You now have " + cargo +" of this item");
            Console.WriteLine("You now have $" + MainMenu.userMoney);
            Console.WriteLine("Your total cargo is: " + MainMenu.userCurrentCargo);
            Console.WriteLine("Press 'Enter' to continue");
            Console.ReadLine();
        }


    }
}
