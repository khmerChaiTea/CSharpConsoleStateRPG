using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleStateRPG
{
    class StateGame
        : State
    {
        protected Character character;

        public StateGame(Stack<State> states, Character activeCharacter)
            : base(states)
        {
            this.character = activeCharacter;
        }

        public void ProcessInput(int input)
        {
            switch (input)
            {
                case -1:
                    this.end = true;
                    break;

                case 1:
                    Console.WriteLine(this.character.ToString());
                    break;

                default:
                    break;

            }
        }

        override public void UpDate()
        {
            Gui.MenuTitle("Game State");
            Gui.MenuOption(1, "Character Stats");
            Gui.MenuOption(-1, "Exit");

            int input = Gui.GetInputInt("Input");

            this.ProcessInput(input);
        }
    }
}
