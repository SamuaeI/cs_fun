using System;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {   
            char[] world = {'_', '_', '_', '_', '_', '_', 'X', '_', '_', '_', '_', '_', '_'};
            bool exit = false;

            do
            {
                Console.WriteLine(displayWorld(world) + "\n");
                string cmd = Convert.ToString(Console.ReadLine()).ToUpper();
                
                switch (cmd)
                {
                    case "R":
                        displayWorld(move_plr(world, "R"));
                        break;
                    case "L":
                        displayWorld(move_plr(world, "L"));
                        break;
                    case "EXIT":
                        exit = true;
                        break;
                    default:
                        break;
                }
                
            } while (!exit);

        }

        static string displayWorld(char[] wrld)
        {
            string the_world = "";
            for (int i = 1; i < wrld.Length; i++)
            {
                the_world += wrld[i];
            }
            Console.Clear();
            return the_world;
        }

        static char[] move_plr(char[] wrld, string direction)
        {
            int plr_index = 0;
            for (int i = 1; i < wrld.Length; i++)
            {
                if (wrld[i] == 'X')
                {
                    plr_index = i;
                }
            }
            if (direction == "R" && plr_index+1 < wrld.Length)
            {
                wrld[plr_index] = '_';
                wrld[plr_index+1] = 'X';
            }
            if (direction == "L" && plr_index-1 > 0)
            {
                wrld[plr_index] = '_';
                wrld[plr_index-1] = 'X';
            }
            return wrld;
        }
    }
}
