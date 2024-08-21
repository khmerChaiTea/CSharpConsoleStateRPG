using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsoleStateRPG
{
    class Gui
    {
        private string header;

        public string Header
        {
            get { return this.header; }
            set { this.header = value; }
        }

        public Gui()
        {
            this.header = "Welcome to the game\n========================================\n"; 
        }

        public void Render()
        {
            Console.WriteLine(this.header);
        }
    }
}
