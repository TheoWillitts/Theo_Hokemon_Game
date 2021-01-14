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
        private int health;
        private int max_health;
        private int attack;
        private int speed;
        private int defense;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Health
        {
            get { return health; }
            set { health = value;  }
        }

        // Methods

        public Hokemon() //Constructor Method
        {
            provide_name();
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

        public void get_details()
        {
            Console.WriteLine("\n-----------------");
            Console.WriteLine("\n\nName: {0}\nHealth: {1}/{2}\nAttack: {3}\nSpeed: {4}\nDefense: {5}", Name, Health, max_health, attack, speed, defense);
            Console.WriteLine("\n\n-----------------");
        }


        public int random_int_generator(int min_value, int max_value)
        {
            Random rnd = new Random();

            int randomValue;

            randomValue = rnd.Next(min_value, max_value);

            return randomValue;
        }
    }
}
