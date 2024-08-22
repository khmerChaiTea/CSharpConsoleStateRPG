using System;
using System.Collections;
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

        private Stack<State> states;
        private ArrayList characterList;

        // Private functions
        private void InitVariables()
        {
            this.end = false;
        }

        private void InitCharacterList()
        {
            this.characterList = new ArrayList();
        }

        private void InitStates()
        {
            this.states = new Stack<State>();

            // Push the first state
            this.states.Push(new StateMainMenu(this.states, this.characterList));
        }

        // Constructor and Destructor
        public Game()
        {
            this.InitVariables();
            this.InitCharacterList();
            this.InitStates();
        }

        public void Run()
        {

            while (this.states.Count > 0)
            {
                this.states.Peek().UpDate();

                if (this.states.Peek().RequestEnd())
                this.states.Pop();
            }

            Console.WriteLine("Ending Game...");
        }
    }
}
