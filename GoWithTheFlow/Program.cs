using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoWithTheFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get users name
            Console.Write("Hello, can you provide me your name? ");
            string playerName = Console.ReadLine();
            Console.WriteLine();

            //Welcome user
            Console.WriteLine("Hello " + playerName + " do you want to know if today is a good day to go outside?");
            Console.WriteLine();

            //Asks user if they want to run the program
            Console.WriteLine("Press 1 for yes and 2 for No");
            int playerSelection = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            //If the player selects yes then this runs
            if (playerSelection == 1)
            {
                //Gives instructions for the user to follow
                Console.WriteLine("Instructions");
                Console.WriteLine("Press 1 for YES");
                Console.WriteLine("Press 2 for NO");
                Console.WriteLine();

                //First question of the flow chart
                Console.WriteLine("Is it raining outside?");
                int confirmRain = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine();
                
                //First split decision of the chart
                if (confirmRain == 1)
                {
                    Console.WriteLine("Do you have a umbrella?");
                    int confirmUmbrella = Convert.ToInt16(Console.ReadLine());
                    Console.WriteLine();

                    if (confirmUmbrella == 1)
                    {
                        Console.WriteLine("You are well equiped to handle the rain, it's safe to proceed outside");
                    } else
                    {
                        Console.WriteLine("I think its in your best intrest to wait a bit");
                        Console.WriteLine();

                        Console.WriteLine("I will start a countdown to let you know when to check again");
                   
                        for (int i = 0; i < 100000; ++i)
                        {
                            Console.Write("\r{0}%   ", i);
                        }

                        Console.WriteLine();
                        Console.WriteLine();

                        Console.WriteLine("Is it still raining?");
                        int stillRaining = Convert.ToInt16(Console.ReadLine());

                        if (stillRaining != 1)
                        {
                            Console.WriteLine("Yay the sun is out and it is safe to proceed outside");
                        } else
                        {
                            Console.WriteLine("I think Netflix is your safest bet for today maybe you can find someone to chill with ;)");
                        }
                    }

                }
                //If the player says no to the program this runs
                else
                {
                    Console.WriteLine("It sounds like a nice day out, it's safe to proceed outside");
                }

            } else
            {
                Console.WriteLine("Thanks for your time press any key to exit :D");
            }
            Console.ReadKey();
        }
    }

}
