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
        protected Character activeCharacter;

        public StateMainMenu(Stack<State> states, ArrayList _characterList)
            : base(states)
        {
            this.characterList = _characterList;
            this.activeCharacter = null;
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
            // While the activeCharacter variable is null, one cannot start the game
            if (this.activeCharacter == null)   // Error
            {
                Gui.Announcement("There is no Active Character selected! Please select one before starting the game.");
            }
            else // Start
            {

            }
        }

        public void SelectCharacter()
        {
            // Print all characters to select
            for (int i = 0; i < this.characterList.Count; i++)
            {
                Console.WriteLine(i + ": " + characterList[i].ToString());
            }

            int choice = Gui.GetInputInt("Character selection");

            try
            {
                this.activeCharacter = (Character)this.characterList[choice];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            if (this.activeCharacter != null)
                Gui.Announcement($"The character {this.activeCharacter.ToString()} is selected.");
        }
    }
}
