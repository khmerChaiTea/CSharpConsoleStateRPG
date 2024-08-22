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
        // Variables
        protected ArrayList characterList;

        // Private functions
        private void CreateCharacter()
        {
            String name = "";
            String description = "";
            Gui.GetInput("Input character name");
            name = Console.ReadLine();
            Gui.GetInput("Input description for character");
            description = Console.ReadLine();

            this.characterList.Add(new Character(name, description));

            Gui.Announcement("Character created");
        }

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
                    this.CreateCharacter();
                    break;

                default:
                    break;

            }
        }

        override public void UpDate()
        {
            Gui.MenuTitle("Character Creator");
            Gui.MenuOption(1, "New Character");
            Gui.MenuOption(2, "Edit Character");
            Gui.MenuOption(3, "Delete Character");
            Gui.MenuOption(-1, "Exit");

            int input = Gui.GetInputInt("Input");

            this.ProcessInput(input);
        }
    }
}
