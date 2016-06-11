/*
 *Author: Dilakshan Packiyanathan
 *Last Modified on June 9th 2016
 *Program Description: Create a Hero class with strength, speed, health and name properties. Assign a random 
 *                     number between 1 and 100 to the abilities.
 *                     determine the damage if hero hits the target and display appropriate messages to the 
 *                     console. 
 *                     Add a SuperHero Class
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2016_Assignment2
{
    class Hero
    {
        //PRIVATE INSTANCE VARIABLES+++++++++++++++++++++++++++++++++++++++++++++++
        private int _strength;
        private int _speed;
        private int _health;
        private string _name;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }

        }


        //ABILITIES GENERATED++++++++++++++++++++++++++++++++++++++++++++++++++
        private void _generateAbilities()
        {
            Random random = new Random();
            _strength = random.Next(1, 101);
            _speed = random.Next(1, 101);
            _health = random.Next(1, 101);
        }

        private bool _hitAttempt()
        {
            Random random = new Random();
            if (random.Next(1, 100) <= 20)
            {
                return true;

            }

            else
            {
                return false;

            }
        }


        //ADDED HITDAMAGE+++++++++++++++++++++++++++++++++++++++++++++++++
        private int _hitDamage()
        {
            Random random = new Random();

            return random.Next(1, 7) * _strength;
        }
        // HEROINFO+++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public void Heroinfo()
        {
            Console.WriteLine("Hero Name: Dilakshan");
            Console.WriteLine("Hero Age: 18");
            Console.WriteLine("Hero Known for: Sense of Humor");

        }


        public void Fighting()
        {
            if (_hitAttempt() == true)

            {
                _hitDamage();
                Console.WriteLine("*************Hit Damage************ {0}", _strength);
            }

            else

                Console.WriteLine("**************Hit Damage************: {0}", _strength);
        }


        //STRENGHT, HEALTH, SPEED+++++++++++++++++++++++++++++++++++++++++++     
        public void ShowAll()
        {
            Console.WriteLine("**************Strength**************: {0}", _strength);
            Console.WriteLine("**************Health****************: {0}", _health);
            Console.WriteLine("**************Speed*****************: {0}", _speed);

        }
        public Hero(string name)
        {
            _name = name;
            _generateAbilities();

        }
    }

}