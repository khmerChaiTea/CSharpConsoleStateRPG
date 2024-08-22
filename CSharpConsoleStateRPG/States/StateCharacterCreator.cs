using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleStateRPG
{
    class StateCharacterCreator
        : State
    {
        protected ArrayList characterList;

        public StateCharacterCreator(Stack<State> states, ArrayList _characterList)
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
                    this.characterList.Add(new Character("Headturna"));
                    this.characterList.Add(new Character("Bob"));
                    this.characterList.Add(new Character("Sven"));
                    Console.Write(Gui.Announcement("Character created"));
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
