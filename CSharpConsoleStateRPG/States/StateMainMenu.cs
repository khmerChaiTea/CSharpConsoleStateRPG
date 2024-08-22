using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleStateRPG
{
    class StateMainMenu 
        : State
    {
        protected ArrayList characterList;

        public StateMainMenu(Stack<State> states, ArrayList _characterList)
            : base(states)
        {
            this.characterList = _characterList;
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
                    this.states.Push(new StateCharacterCreator(this.states, this.characterList));
                    break;

                case 3:
                    Console.WriteLine(this.characterList.Count);
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
            Console.Write(Gui.MenuOption(3, "List Characters"));
            Console.Write(Gui.MenuOption(-1, "Exit"));

            Gui.GetInput("Input");
            int input = Convert.ToInt32(Console.ReadLine());

            this.ProcessInput(input);
        }
    }
}
