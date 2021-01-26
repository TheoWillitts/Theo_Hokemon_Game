using System;

namespace Hokemon_T
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the world of Hokemon!");

            // Instantiating a Hokemon

            Hokemon Hoke1 = new Hokemon();
            Hoke1.get_details();

            Hoke1.about();

            System.Threading.Thread.Sleep(1000);

            //Instantiating another Hokemon

            Hokemon Hoke2 = new Hokemon();
            Hoke2.get_details();

            Hoke2.about();

            System.Threading.Thread.Sleep(1000);

            //Instantiating another Hokemon

            Hokemon Hoke3 = new Hokemon();
            Hoke3.get_details();

            Hoke3.about();

            System.Threading.Thread.Sleep(1000);

            //Instantiating another Hokemon

            Hokemon Hoke4 = new Hokemon();
            Hoke4.get_details();

            Hoke4.about();

            System.Threading.Thread.Sleep(1000);




            BattleArena firstArena = new BattleArena(); //Instantiating the object firstArena
                                                        //From the BattleArena class

            firstArena.RequestAChallenger(Hoke1);

            firstArena.AcceptABattle(Hoke1, Hoke2);

            
            firstArena.Battle(Hoke1, Hoke2);
            
        }
    }
}
