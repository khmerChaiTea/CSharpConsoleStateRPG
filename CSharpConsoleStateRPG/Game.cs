using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleStateRPG
{
    internal class Game
    {
        // Variable
        private bool end;

        public bool End
        {
            get { return this.end; }
            set { this.end = value; }
        }

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
            this.states.Push(new State(this.states));
        }

        // Constructor and Destructor
        public Game()
        {
            this.InitVariables();
            this.InitStates();

            Console.WriteLine("Hello from the Game class!");
        }

        public void Run()
        {
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
