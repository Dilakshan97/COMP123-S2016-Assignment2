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
    class Program
    {
        static void Main(string[] args)
        {
            Hero hero = new Hero("Dilakshan");
            hero.ShowAll();
            hero.Fighting();
            hero.Heroinfo();

            Console.WriteLine();
            Console.Write("Press Enter to view Super Powers");
            Console.ReadLine();
            Console.WriteLine();

            SuperHero superHero = new SuperHero("Dilakshan");
            superHero.ShowPower();
            superHero.ShowPower();
        }
    }
}