using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleStateRPG
{
    class StateCharacterCreator
        : State
    {
        public StateCharacterCreator(Stack<State> states) : base(states)
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
            Console.Write(Gui.MenuTitle("Character Creator"));
            Console.Write(Gui.MenuOption(1, "New Character"));
            Console.Write(Gui.MenuOption(2, "Edit Character"));
            Console.Write(Gui.MenuOption(3, "Delete Character"));
            Console.Write(Gui.MenuOption(-1, "Exit"));

            Gui.GetInput("Input");
            int input = Convert.ToInt32(Console.ReadLine());

            this.ProcessInput(input);
        }
    }
}
