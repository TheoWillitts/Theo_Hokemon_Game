using System;
using System.Collections.Generic;
using System.Text;

namespace Hokemon_T
{
    class Hokemon
    {
        // MEMBERS - All Attributes, MEthods and Properties are Members of this class.
        // VARIABLES a.k.a ATTRIBUTES inside a class can also be referred to as fields.

        
        private string name;
        private string nextMove;
        private string team;
        private int health;
        private int max_health;
        private int attack;
        private int speed;
        private int defense;
        private int special_attack_name;
        private int special_attack_damage;


        public string Name { get; set; }

        public string Team { get; set; }

        public int Health { get; set; }

        public int SpecialAttackName { get; set; }


        public string[] battle_responses =
        {
        "Just what i was looking for in an opponent...",
        "You thought you could beat me?!??",
        "You thought you could win?!??",
        "How dare you face me with such disgrace!",
        };

        public string[] halor_team_responses =
        {
        "Great choice, welcome to team Halor!",
        "Welcome aboard fellow Halor, dinner's served at six my friend.",
        "Glad to have another addition to team Halor...",
        "Oh dear, another one for the cleaning group..."
        };

        public string[] hystic_team_responses =
        {
        "Great choice, welcome to team Hystic!",
        "Welcome aboard fellow Hystic, dinner's served at seven my friend.",
        "Glad to have another addition to team Hystic...",
        "Oh dear, another one for the cooking clan..."
        };

        public string[] hinstinct_team_responses =
        {
        "Great choice, welcome to team Hinstinct!",
        "Welcome aboard fellow Hinstinct, breakfast at 8:00 my friend.",
        "Glad to have another addition to team Hinstinct...",
        "Oh great, another one for the team..."
        };


        // Methods

        public Hokemon() //Constructor Method
        {
            provide_name();
            provide_team();
            max_health = 100;
            health = random_int_generator(10, max_health);
            attack = random_int_generator(10, max_health);
            speed = random_int_generator(10, max_health);
            defense = random_int_generator(10, max_health);

        }

        

        public void provide_name()
        {
            Console.WriteLine("Enter a name for your hokemon: ");
            name = Console.ReadLine();
        }

        private void provide_team()
        {
            Console.WriteLine("What team are your hokemon from Halor, Hinstinct or Hystic: ");
            team = Console.ReadLine();
            
            if(team.ToUpper() == "HALOR")
            {
                Random rand = new Random();
                int index = rand.Next(halor_team_responses.Length);
                Console.WriteLine($"{halor_team_responses[index]}");
            }

            if (team.ToUpper() == "HINSTINCT")
            {
                Random rand = new Random();
                int index = rand.Next(hinstinct_team_responses.Length);
                Console.WriteLine($"{hinstinct_team_responses[index]}");
            }

            if (team.ToUpper() == "HYSTIC")
            {
                Random rand = new Random();
                int index = rand.Next(hystic_team_responses.Length);
                Console.WriteLine($"{hystic_team_responses[index]}");
            }
        }

        public void get_details()
        {
            Console.WriteLine("\n-----------------");
            Console.WriteLine($"\n\nName: {Name}\nTeam: {Team}\nHealth: {Health}/{max_health}\nAttack: {attack}\nSpeed: {speed}\nDefense: {defense}");
            Console.WriteLine("\n\n-----------------\n\n");
        }

        public void get_next_move()
        {
            Console.WriteLine("The battle begins!!");
            Console.WriteLine("\n\n{0}: I attack with {1}!", Name, attack);
            Console.WriteLine("What is your move {0}, attack or defend?", Name);
        }

        public int random_int_generator(int min_value, int max_value)
        {
            Random rnd = new Random();

            int randomValue;

            randomValue = rnd.Next(min_value, max_value);

            return randomValue;
        }

        public void about()
        {
            Console.WriteLine("I am a mystical species known as a Hokemon! I'm here to defeat anyone who dares face me... \n");
            Console.WriteLine($"I'm from team {team}, we're gonna rule the world one day!");
        }

        public int attackCalc() //Calculating the attack value for the hokemon when they are in battle.
        {
            int attackValue;

            attackValue = ((attack + speed) - (defense / 2)) * random_int_generator(1,2);

            return attackValue;
        }

        public int defenseCalc() //Calculating the defense value for the hokemon when they are in battle.
        {
            int defenseValue;

            defenseValue = defense * random_int_generator(1,3);

            return defenseValue;
        }

        public int specialAttackCalc() //Calculating the attack value for the hokemon when they are in battle.
        {
            int special_attack_damageValue;

            special_attack_damageValue = ((attack + speed) - (defense / 8)) * random_int_generator(1, 5);

            return special_attack_damageValue;
        }

    }
}
