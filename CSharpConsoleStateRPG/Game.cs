using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleStateRPG
{
    class Game
    {
        // Variable
        private bool end;

        public bool End
        {
            get { return this.end; }
            set { this.end = value; }
        }

        private Gui gui;

        private Stack<State> states;

        // Private functions
        private void InitVariables()
        {
            this.end = false;
        }

        private void InitStates()
        {
            this.states = new Stack<State>();

            // Push the first state
            this.states.Push(new StateMainMenu(this.states));
        }

        private void InitGui()
        {
            this.gui = new Gui();
        }

        // Constructor and Destructor
        public Game()
        {
            this.InitVariables();
            this.InitStates();
            this.InitGui();
        }

        public void Run()
        {
            this.gui.Render();

            while (this.end == false)
            {
                Console.WriteLine("Write a number: ");
                int number =  Convert.ToInt32(Console.ReadLine());

                if (number < 0)
                    this.end = true;
                else
                    Console.WriteLine("You inputted: " + number);
            }

            Console.WriteLine("Ending Game...");
        }
    }
}
