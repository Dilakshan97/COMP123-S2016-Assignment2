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

    class SuperHero : Hero
    {
        //PRIVATE INSTANCE VARIABLES+++++++++++++++++++++++++++++++++++++++++++
        string[] _superPowers = new string[6];
        List<string> SuperPower = new List<string>();



        //PUBLIC PROPERTIES++++++++++++++++++++++++++++++++++++++++++
     
        public string SuperPowers
        {
            get
            {
                return this._superPowers[6];
            }

            set
            {
                this._superPowers[6] = value;
            }
        }

        // CONSTRUCTORS++++++++++++++++++++++
       
        public SuperHero(string name) : base(name)
        {
            _generateRandomPowers();
        }

        //PUBLIC METHODS+++++++++++++++++++++++++++++++++++++++++++++++++++++
        
        private void _generateRandomPowers()
        {
            List<string> randomPowers = new List<string>();
            randomPowers.Add("Body Armour"); randomPowers.Add("Super Strength"); randomPowers.Add("Super Speed"); randomPowers.Add("Weather Control"); randomPowers.Add("Fire Generation"); randomPowers.Add("Flight");
            randomPowers.Add("Teleporting"); randomPowers.Add("Time Travelling"); randomPowers.Add("Freeze"); randomPowers.Add("Psychosis"); randomPowers.Add("HeatWave");
            randomPowers.Add("Gravitational Pull"); randomPowers.Add("Read Mind"); randomPowers.Add("Object Creation"); randomPowers.Add("Control WildLife");
   
            Random rnd = new Random();

            for (int count = 0; count < 6; count++)
            {
                int randomNumber = rnd.Next(0, randomPowers.Count);

                _superPowers[count] = randomPowers.ElementAt(randomNumber);
                randomPowers.RemoveAt(randomNumber);

            }
           

            foreach (string power in _superPowers)
            {
                SuperPower.Add(power);
            }
        }

        //++++++++++++++++++++++++++++++++++++++++++++++++
        
        public void ShowPower()
        {
            foreach (string power in SuperPower)
            {
                Console.WriteLine(power);
            }

        }
    }
}