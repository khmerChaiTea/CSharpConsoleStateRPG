using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleStateRPG
{
    class StateGame
        : State
    {
        public StateGame(Stack<State> states) : base(states)
        {

        }

        override public void UpDate()
        {
            Console.WriteLine("Write a number (Game): ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
                this.end = true;
        }
    }
}
