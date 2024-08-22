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
        Character character;

        public StateMainMenu(Stack<State> states)
            : base(states)
        {
            this.character = new Character("Head");
        }

        override public void UpDate()
        {
            Console.Write(Gui.MenuTitle("Main Menu"));
            Console.Write(Gui.MenuOption(0, "Create Character"));
            Console.Write(Gui.MenuOption(-1, "Exit"));

            Console.WriteLine(character.ToString());

            Console.WriteLine("Write a number: (Main Menu)");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
                this.end = true;
        }
    }
}
