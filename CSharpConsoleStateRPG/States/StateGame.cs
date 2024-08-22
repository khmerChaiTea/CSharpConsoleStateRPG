﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleStateRPG
{
    class StateGame
        : State
    {
        public StateGame(Stack<State> states) : base(states)
        {
            
        }

        public void ProcessInput(int input)
        {
            switch (input)
            {
                case -1:
                    this.end = true;
                    break;

                default:
                    break;

            }
        }

        override public void UpDate()
        {
            Console.Write(Gui.MenuTitle("Game State"));
            Console.Write(Gui.MenuOption(1, "Create Character"));
            Console.Write(Gui.MenuOption(-1, "Exit"));

            Gui.GetInput("Input");
            Gui.GetInput("Input");
            int input = Convert.ToInt32(Console.ReadLine());

            this.ProcessInput(input);
        }
    }
}
