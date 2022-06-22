using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace OOPBF
{
    internal class Menu
    {
        public string Examples;
        public string[] Options;
        public int Select;

        public Menu(int select, string[] options, string examples)
        {
            Options = options;
            Examples = examples;
            Select = 0;
        }

        public void ShowOptions()
        {
            WriteLine(Examples);
            for (int i = 0; i < Options.Length; i++)
            {
                string currentOptions = Options[i];
                string foran;
                if (i == Select)
                {
                    foran = @"
";
                    ForegroundColor = ConsoleColor.Red;

                }
                else
                {

                    foran = " ";
                    ForegroundColor = ConsoleColor.Yellow;

                }

                WriteLine($"{foran}{currentOptions}");
            }
            ResetColor();
        }

        public static void startMenu()
        {

            string foran = "";
            string[] options = { @"

                                                                                              ██████╗ ██╗      █████╗ ██╗   ██╗
                                                                                              ██╔══██╗██║     ██╔══██╗╚██╗ ██╔╝
                                                                                              ██████╔╝██║     ███████║ ╚████╔╝ 
                                                                                              ██╔═══╝ ██║     ██╔══██║  ╚██╔╝  
                                                                                              ██║     ███████╗██║  ██║   ██║   
                                                                                              ╚═╝     ╚══════╝╚═╝  ╚═╝   ╚═╝   
                                 

", @"
                                                                                          █████╗ ██████╗  ██████╗ ██╗   ██╗████████╗
                                                                                          ██╔══██╗██╔══██╗██╔═══██╗██║   ██║╚══██╔══╝
                                                                                          ███████║██████╔╝██║   ██║██║   ██║   ██║   
                                                                                          ██╔══██║██╔══██╗██║   ██║██║   ██║   ██║   
                                                                                          ██║  ██║██████╔╝╚██████╔╝╚██████╔╝   ██║   
                                                                                          ╚═╝  ╚═╝╚═════╝  ╚═════╝  ╚═════╝    ╚═╝     
 
                                           
", @"

                                                                                                 ███████╗██╗  ██╗██╗████████╗
                                                                                                 ██╔════╝╚██╗██╔╝██║╚══██╔══╝
                                                                                                 █████╗   ╚███╔╝ ██║   ██║   
                                                                                                 ██╔══╝   ██╔██╗ ██║   ██║   
                                                                                                 ███████╗██╔╝ ██╗██║   ██║   
                                                                                                 ╚══════╝╚═╝  ╚═╝╚═╝   ╚═╝                                                                                 
                                                                                           
                                                                

" };        

            Menu mainMenu1 = new Menu(0, options, foran);
            int Select = mainMenu1.Run();
            mainMenu1.ShowOptions();
            switch (Select)
            {
                case 0:
                    Clear();
                    StartGame();


                    break;
                case 1:
                    Clear();
                    About();
                    startMenu();
                    break;

                case 2:
                    Clear();
                    Exit();
                    break;
            }
            Clear();
        }
        
        public static void Exit()
        {
            WriteLine("Press any key to exit.");
            ReadKey(true);
            Environment.Exit(0);
        }

        public static void About()
        {
            Clear();
            WriteLine("Nope, nothings here yet");
            ReadKey(true);
            startMenu();
        }

        public static void StartGame()
        {Beginning start = new Beginning();
            Clear();
            start.Start();
            ReadKey(true);
        }

        public int Run()
        {
            ConsoleKey pressed;
            do
            {
                Clear();
                ShowOptions();
                ConsoleKeyInfo keyInfo = ReadKey(true);
                pressed = keyInfo.Key;
                if (pressed == ConsoleKey.UpArrow)
                {
                    Select--;
                    if (Select == -1)
                    {
                        Select = Options.Length - 1;
                    }

                }
                else if (pressed == ConsoleKey.DownArrow)
                {
                    Select++;
                    if (Select == Options.Length)
                    {
                        Select = 0;
                    }
                }
            } while (pressed != ConsoleKey.Enter);

            return Select;
        }
        public static void Logo()
        {
           
            ForegroundColor = ConsoleColor.Yellow;
            CursorVisible = false;
            WriteLine(@"             





                                                                                                                                                                                                                                                                
                        8 888888888o   8 8888                  .8.          8 888888888o.    `8.`888b           ,8' 8 8888888888   b.             8 8888888 8888888888 8 8888      88 8 888888888o.   8 8888888888   
                        8 8888    `88. 8 8888                 .888.         8 8888    `^888.  `8.`888b         ,8'  8 8888         888o.          8       8 8888       8 8888      88 8 8888    `88.  8 8888         
                        8 8888     `88 8 8888                :88888.        8 8888        `88. `8.`888b       ,8'   8 8888         Y88888o.       8       8 8888       8 8888      88 8 8888     `88  8 8888         
                        8 8888     ,88 8 8888               . `88888.       8 8888         `88  `8.`888b     ,8'    8 8888         .`Y888888o.    8       8 8888       8 8888      88 8 8888     ,88  8 8888         
                        8 8888.   ,88' 8 8888              .8. `88888.      8 8888          88   `8.`888b   ,8'     8 888888888888 8o. `Y888888o. 8       8 8888       8 8888      88 8 8888.   ,88'  8 888888888888 
                        8 8888888888   8 8888             .8`8. `88888.     8 8888          88    `8.`888b ,8'      8 8888         8`Y8o. `Y88888o8       8 8888       8 8888      88 8 888888888P'   8 8888         
                        8 8888    `88. 8 8888            .8' `8. `88888.    8 8888         ,88     `8.`888b8'       8 8888         8   `Y8o. `Y8888       8 8888       8 8888      88 8 8888`8b       8 8888         
                        8 8888      88 8 8888           .8'   `8. `88888.   8 8888        ,88'      `8.`888'        8 8888         8      `Y8o. `Y8       8 8888       ` 8888     ,8P 8 8888 `8b.     8 8888         
                        8 8888    ,88' 8 8888          .888888888. `88888.  8 8888    ,o88P'         `8.`8'         8 8888         8         `Y8o.`       8 8888         8888   ,d8P  8 8888   `8b.   8 8888         
                        8 888888888P   8 888888888888 .8'       `8. `88888. 8 888888888P'             `8.`          8 888888888888 8            `Yo       8 8888          `Y88888P'   8 8888     `88. 8 888888888888 "
 );
            ForegroundColor = ConsoleColor.White;
            WriteLine(@"                                                                                            






                                                                                              >>>Press ENTER to start<<<");
            ConsoleKey pressed;
            ConsoleKeyInfo keyInfo = ReadKey(true);
            pressed = keyInfo.Key;
            if (pressed == ConsoleKey.Enter)
            {
                startMenu();
            }
            ResetColor();
        }
    }
}
    

