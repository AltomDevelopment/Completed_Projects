using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceTraderProject
{
    class GameStory
    {
        //display story and directions
        public void DisplayGameStory()
        {
            string story = "The year was 3401 and you are a famous space traveler who made a fortune smuggling goods for the" + "\n" +
                            "Galactic Cartel. There wasn't a space cop in the galaxy who didn't know who you were.A majority of your" + "\n" +
                            "life was spent on the Galaxy's Most Wanted list. Until, it all came crashing down. On a fairly routine" + "\n" +
                            "smuggling run to Saturn, you were betrayed." + "\n"+ "\n" +

                            "Space travler2 had been part of your crew for the last couple years.You and ST2 had become friends in that" + "\n" +
                            "time but the Galactic Police got dirt on him.ST2 had made a mistake, when he was an amateur smuggler, that" + "\n" +
                            "lead to the death of a cop.He has been on the run ever since, but the police finally caught up to him." + "\n" + "\n" +

                            "After making a delivery on Saturn you and ST2 were in a bar celebrating another successful delivery. ST2 stepped" + "\n" +
                            "outside for a smoke when the cops used their intel to arrest him.You were unaware he was arrested.You assumed" + "\n" +
                            "he found a companion for the night and went home." + "\n" +


                            "When the police brought him in for questioning, he sold you out. He made a deal.He told them he would turn you" + "\n" +
                            "in to save himself.While you were sleeping on your ship, the police barged in and arrested you.You were sentenced" + "\n" +
                            "to 21 years in the Galactic Penitentiary." + "\n" +

                            "The year is now 3422 and you are out of prison.In your old age, you've decided to make an honest living from now on." + "\n" +
                            "You will now earn your living as a straight forward space trader.Good Luck!!";

            Console.WriteLine(story);
            Console.ReadLine();
            Console.Clear();
        }

        public void DisplayGameDirections()
        {
            string directions = "In this game you will be SpaceTraver and travel between planets buying and selling cargo" + "\n" +
                                "to make as much money as possible." + "\n" +

                                "You will start the game with $1,000,000." + "\n" + "\n" +

                                "- There are eight planets." + "\n" +

                                "- Each planet will have a Trading Post where you can buy and sell." + "\n" +
    
                                 "-Each planet will have its own economy." + "\n" +
    
                                 "-Traveling will cause time to pass." + "\n" + "\n" +


                                "- You will begin with a Basic Ship" + "\n" +

                                 "-Ability to upgrade ship at Trading Posts." + "\n" +

                                "-Each upgrade will increase speed of travel and cargo capacity." + "\n" + "\n" +

                                "Game will end when:" + "\n" +

                                "-You decide to Quit the game." + "\n" +

                                "- You reach 40 years of travel time" + "\n" +

                                "-You run out of money.";

            Console.WriteLine(directions);
            Console.ReadLine();
            Console.Clear();
        }
    
    }
}
