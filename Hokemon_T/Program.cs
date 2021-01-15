using System;

namespace Hokemon_T
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the world of Hokemon!");

            // INSTANTIATION of first object

            Hokemon HokeObject01 = new Hokemon();

            HokeObject01.get_details();

            //Time wait
            System.Threading.Thread.Sleep(1000); // Sleep for one second.
            
            //Creating second Hokemon

            Hokemon HokeObject02 = new Hokemon();

            HokeObject02.get_details();

            BattleArena firstArena = new BattleArena(); //Instantiating the object firstArena
                                                        //From the BattleArena class

            firstArena.RequestAChallenger(HokeObject01);

            firstArena.AcceptABattle(HokeObject01, HokeObject02);
        }
    }
}
