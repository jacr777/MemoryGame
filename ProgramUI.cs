using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MemoryGame
{

    public class  ProgramUI
    {
        public void Run()
        {
            Menu();
        }
        public static List<int> CreateRandomNumbers(int count) //Creates a method that will return list that takes one integer an sets the amount of numbers to return
        {
            List<int> randomNumbers = new List<int>(); // Create a list of integers
             
            //starts in 0 while the counter is less thant the number, increases the counter 
            for (int i = 0; i < count; i++)             
            {
                //int number;                                // Define a int as number
                //do number = new Random().Next(0,10);       //Do While Loop
                //while (randomNumbers.Contains(number));    // This was causing an inifinite loop over 10

                randomNumbers.Add(new Random().Next(0, 10)); //Generates the random number between 0 and 10... this can be changed!!
                System.Threading.Thread.Sleep(1);            //the sleep helps the randomizer generte a different Number if not


                // randomNumbers.Add(number);                //Adds the random number to the list
            }

            return randomNumbers;                            // Returns the list
        }

        private void Menu()
        {
            bool keepRunning = true;
            int level = 1; // Initial Level 
            int time = 2000; //Initial Time
            Console.WriteLine("Would you like to play the game?(Yes/No)");
            string word = Console.ReadLine().ToLower();
            while (keepRunning)
            {  
                if (word == "yes")
                {
                    Console.Clear();
                    var random = CreateRandomNumbers(level);
                    string rndm = string.Join(" ", random); //Make a the list into a string to compare with the readkey

                    //string.Join( ",", myList);
                    Console.WriteLine("Remember this number(s)!!\n");

                    foreach (int number in random)
                    {
                        Console.WriteLine("{0,8:N0}", number);
                    }

            
                    System.Threading.Thread.Sleep(time); 
                    Console.Clear(); //Clear the console 
                    Console.WriteLine("Can you remember the number(s)");
                    string guess = Console.ReadLine();

                    if (guess == rndm && level == 5)
                    {
                        Console.WriteLine("Excellent! You move to the next level\n" +
                            "You got an easter Egg\n" +
                      "                               .8\n" +
                      "                            .888\n" +
                      "                          .8888'\n" +
                      "                         .8888'\n" +
                      "                         888'\n" +
                      "                         8'\n" +
                      "            .88888888888. .88888888888.\n" +
                      "         .8888888888888888888888888888888.\n" +
                      "       .8888888888888888888888888888888888.\n" +
                      "      .&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&& &'\n" +
                      "      &&&&&&&&&&&&&&&&&&&&&&&&&&&&&&&& '\n" +
                      "      &&&&&&&&&&&&&&&&&&&&&&&&&&&&&& &'\n" +
                      "     @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@:\n" +
                      "     @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@:\n" +
                      "     @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@:\n" +
                      "      %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%.\n" +
                      "      %%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%.\n" +
                      "      `%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%.\n" +
                      "       `00000000000000000000000000000000000'\n" +
                      "        `000000000000000000000000000000000'\n" +
                      "         `0000000000000000000000000000000'\n" +
                      "           `###########################'\n" +
                      "             `#######################'\n" +
                      "               `#########''########'\n" +
                      "                 `''''''''  `'''''' \n" +
                        "Press any key to continue");
                        Console.ReadKey();
                        level++;
                        time = time + 500; // Figure Shorthand later
                    }
                    else if (guess == rndm)
                    {
                        Console.WriteLine("Excellent! You move to the next level\n" +
                        "Press any key to continue");
                        Console.ReadKey();
                        level++;
                        time = time + 500;
                    }
                    else if (guess == "1150")
                    {
                        Console.WriteLine("You made it to LEVEL 500, the 1150 Level\n" +
                     "\n" +
                     "\n" +
                     "       ▄▄▄▄         ▄▄▄▄      ▄▄▄▄▄▄▄▄▄▄▄   ▄▄▄▄▄▄▄▄▄  \n" +
                     "     ▄█░░░░▌      ▄█░░░░▌    ▐░░░░░░░░░░░▌ ▐░░░░░░░░░▌ \n" +
                     "    ▐░░▌▐░░▌     ▐░░▌▐░░▌    ▐░█▀▀▀▀▀▀▀▀▀ ▐░█░█▀▀▀▀▀█░▌\n" +
                     "     ▀▀ ▐░░▌      ▀▀ ▐░░▌    ▐░█▄▄▄▄▄▄▄▄▄ ▐░▌▐░▌    ▐░▌\n" +
                     "        ▐░░▌         ▐░░▌    ▐░░░░░░░░░░░▌▐░▌ ▐░▌   ▐░▌\n" +
                     "        ▐░░▌         ▐░░▌     ▀▀▀▀▀▀▀▀▀█░▌▐░▌  ▐░▌  ▐░▌\n" +
                     "        ▐░░▌         ▐░░▌              ▐░▌▐░▌   ▐░▌ ▐░▌\n" +
                     "        ▐░░▌         ▐░░▌              ▐░▌▐░▌    ▐░▌▐░▌\n" +
                     "    ▄▄▄▄█░░█▄▄▄  ▄▄▄▄█░░█▄▄▄  ▄▄▄▄▄▄▄▄▄█░▌▐░█▄▄▄▄▄█░█░▌\n" +
                     "   ▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌▐░░░░░░░░░░░▌ ▐░░░░░░░░░▌\n" + 
                     "    ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀  ▀▀▀▀▀▀▀▀▀▀▀   ▀▀▀▀▀▀▀▀▀\n" +
                     "\n" +
                        "Are you Ready???????  -------- Only a few Dare!!!!!!\n" +
                        "Press any key at your own RISK!!!");
                        Console.ReadKey();
                        level= 500;
                        time = 20000;
                    }
                    else
                    {
                        Console.WriteLine("I'm sorry! You Lost, Bye!!!\n" +
                       "     .- '''' -.\n" +
                       "   .'          '.\n" +
                       "  / O      O     \\ \n" +
                       " :   `       `    :\n" +
                       " |                |\n" +
                       " :    .------.    :\n" +
                       "  \\  '       '   /\n" +
                       "   '.          .'\n" +
                       "     '-......-'\n" +

                        "Press any key to Exit");
                        Console.ReadKey();
                        keepRunning = false;
                    }
                }
                else
                {
                    keepRunning = false;
                }
            }
        }

    }

}
