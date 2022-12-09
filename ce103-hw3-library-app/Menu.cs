using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ce103_hw3_library_app
{
    internal class Menu
    {
        private int mainChoice;
        private string[] Options;
        private string Prompt;

        public Menu(string prompt, string[] options)
        {
            Prompt = prompt;
            Options = options;
            mainChoice = 0;
        }

        private void DisplayOptions()
        {
            WriteLine(Prompt);
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string prefix;

                if (i == mainChoice)
                {
                    prefix = "*";
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.Green;
                }
                else
                {
                    prefix = " ";
                    ForegroundColor = ConsoleColor.Red;
                    BackgroundColor = ConsoleColor.Black;
                }
                WriteLine($"<< {currentOption} >>");
            }
            ResetColor();
        }

        public int Run()
        {
            ConsoleKey keyPressed;
            do
            {
                Clear();
                DisplayOptions();

                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;

                // Update mainChoice based on arrow key
                if (keyPressed == ConsoleKey.UpArrow)
                {
                    mainChoice--;
                    if (mainChoice == -1)
                    {
                        mainChoice = Options.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow)
                {
                    mainChoice++;
                    if (mainChoice == Options.Length)
                    {
                        mainChoice = 0;
                    }
                }
            } while (keyPressed != ConsoleKey.Enter);

            return mainChoice;
        }

    }

}
