using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon_T
{
    class Halor : Hokemon
    {
        private string team = "Halor";

        public void about() // POLYMORPHISM from the Hokemon about() method
        {
            Console.WriteLine("I am {0}, part of team {1}!!", Name, team);
        }
    }
}
