using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon_T
{
    class BattleArena
    {
        public BattleArena()
        {               // Constructor method runs first when OBJECT INSTANTIATED
            Console.WriteLine("**** **** BATTLE ARENA **** ****");

        }
        
        public void RequestAChallenger(Hokemon contender)
        {
            Console.WriteLine("{0}: I want to battle... who wants it? ", contender.Name);
            
        }
    
        public void AcceptABattle(Hokemon contender1, Hokemon contender2)
        {
            Console.WriteLine("{0}: Who dares question my power, I'll take you on {1}!! ", contender2.Name, contender1.Name);
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("{1}: Great {0}, lets start a BATTLE!!!", contender2.Name, contender1.Name);
        }
    }

}
