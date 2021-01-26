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
            Console.WriteLine("   WELCOME TO THE BATTLE ARENA  ");
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

        public void Battle(Hokemon Attacker, Hokemon Defender)
        {
            Hokemon tempHoke;
            int round = 0;

            while (Convert.ToInt32(Attacker.Health) >= 0 || Convert.ToInt32(Defender.Health) >= 0)
            {
                int attackValue = Attacker.attackCalc();
                int defenseValue = Defender.defenseCalc();

                round += 1; // Short version of: round = round + 1

                Console.WriteLine("\n ~~~~Round {0}~~~~", round);

                for (int i = 0; i < 2; i++)
                {

                    // Attacker attacks

                    Console.WriteLine("{0} ****Attacks for {1}****", Attacker.Name, attackValue);

                    // Defenders defense

                    Console.WriteLine("{0}: I'm going strong, my health is at {1}!", Defender.Name, Defender.Health);
                    Console.WriteLine("{0} ****Defends for {1}****", Defender.Name, defenseValue);

                    // Calculations

                    Defender.Health = (Defender.Health + defenseValue) - attackValue;

                    Console.WriteLine("{0}: I've been hit, my health has been depleated to {1}!", Defender.Name, Defender.Health);

                    Console.WriteLine("\n\n ~~~~SWITCHING TURNS~~~~ \n\n");

                    // Switching roles:
                    tempHoke = Attacker;
                    Attacker = Defender;
                    Defender = tempHoke;


            
                }
            }

            if (Attacker.Health > Defender.Health)
            {
                Console.WriteLine("{0} Wins this battle!", Attacker.Name);
            }
            else
            {
                Console.WriteLine("{0} Wins this battle!", Defender.Name);
            }
        }
    }

}
