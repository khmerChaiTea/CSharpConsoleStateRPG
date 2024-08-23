﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleStateRPG
{
    class Gui
    {
        public static void Title(String str)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            str = String.Format("===== {0} =====\n\n", str);

            Console.Write(str);
            Console.ResetColor();
        }

        public static void MenuTitle(String str)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            str = String.Format("======= {0} =======\n\n", str);

            Console.Write(str);
            Console.ResetColor();
        }

        public static void MenuOption(int index, String str)
        {
            str = String.Format(" - ({0}) : {1}\n", index, str);

            Console.Write(str);
        }

        public static void Announcement(String str)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            str = String.Format("\t(~) {0}!\n", str);

            Console.Write(str);
            Console.ResetColor();
        }

        public static String ProgressBar(int min, int max, int width)
        {
            String bar = "[";

            double percent = (double)min / max;
            int complete = Convert.ToInt32(percent * width);
            int incomplete = width - complete;

            for (int i = 0; i < complete; i++)
            {
                bar += "=";
            }
            for (int i = 0; i < width; i++)
            {
                bar += "-";
            }

            bar += "]";

            return bar;
        }

        public static void GetInput(String str)
        {
            str = String.Format(" - {0}: ", str);

            Console.Write(str);
        }

        public static int GetInputInt(string message)
        {
            Nullable<int> input = null;

            while (input == null)
            {
                try
                {
                    Gui.GetInput(message);
                    input = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e) // Error
                {                    
                    Console.WriteLine(e.Message);
                }
            }

            return input.Value;
        }
    }
}
