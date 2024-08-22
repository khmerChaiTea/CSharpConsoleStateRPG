using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleStateRPG
{
    class StateMainMenu 
        : State
    {
        public StateMainMenu(Stack<State> states)
            : base(states)
        {
            
        }

        public void ProcessInput(int input)
        {
            switch (input)
            {
                case -1:
                    this.end = true;
                    break;

                case 1:

                    break;

                case 2:
                    this.states.Push(new StateCharacterCreator(this.states));
                    break;

                default:
                    break;

            }
        }

        override public void UpDate()
        {
            Console.Write(Gui.MenuTitle("Main Menu"));
            Console.Write(Gui.MenuOption(1, "New Game"));
            Console.Write(Gui.MenuOption(2, "Character Creator"));
            Console.Write(Gui.MenuOption(-1, "Exit"));

            Console.WriteLine("Write a number: (Main Menu)");
            int input = Convert.ToInt32(Console.ReadLine());

            this.ProcessInput(input);
        }
    }
}
