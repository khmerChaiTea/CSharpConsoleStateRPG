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
                    this.StartNewGame();
                    break;

                case 2:
                    this.states.Push(new StateCharacterCreator(this.states, this.characterList));
                    break;

                case 3:
                    this.SelectCharacter();
                    break;

                default:
                    break;

            }
        }

        override public void UpDate()
        {
            Gui.MenuTitle("Main Menu");
            Gui.MenuOption(1, "New Game");
            Gui.MenuOption(2, "Character Creator");
            Gui.MenuOption(3, "Select Characters");
            Gui.MenuOption(-1, "Exit");

            int input = Gui.GetInputInt("Input");

            this.ProcessInput(input);
        }

        public void StartNewGame()
        {

        }

        public void SelectCharacter()
        {
            foreach (var character in this.characterList)
            {
                Console.WriteLine(character.ToString());
            }
        }
    }
}
