using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLock3
{
    internal class Enums
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enums\n");

            #region Notes - Enums   

            /*
             * Enums (a.k.a. Enumerators) are a data type that hold a list of uniquely named constants.
             * 
             * You cannot create an enum directly through the Visual Studio interface. Instead, you
             * will need to create a class and then adapt it into an enum.
             * 
             * When defining values for an enum, they must be single values with NO SPACES in a 
             * COMMA SEPARATED list.
             * 
             * You can OPTIONALLY assign numeric values to represent each item in the enum. These serve
             * the same purpose as indec numbers: they are used to look up the data.
             * 
             * IF you do not assign each item a numeric value, the compiler will use the default (0-based).
             * 
             * Why are enums useful? They can help restrict choices. As an example, an enum would be 
             * a great structure to hold card suits (Spades, Clubs, Hearts, Diamonds).
             * 
             * Enums are different 
             * 
             
             * 
             * 
             * 
             * 
             * 
             */





            #endregion

            //We can use values from an enum just like we would with normal variables
            Console.WriteLine("My favorite classic monster is " + Classicmonsters.Dracula + "!");

            //Because enums are NOT collections, we cannot iterate through them directly.
            //However, we can use the static Enum.GetValues() to pull all of the enum values
            //out and organize them into an array -- which we CAN iterate through,
            Console.WriteLine("\nList of Classic Monsters");

            int index = 0; //WE can use this variable to print out the index as we loop

            foreach (var item in Enum.GetValues(typeof(Classicmonsters)))
            {
                Console.WriteLine(item + " is at the index of " + index);
                index++;

            }

            //Enum grant some unique functionality when used with a switch in Visual Studio
            Console.WriteLine("\nChoose a Classic Monster from the list above (enter the number only): ");
            int userInput = int.Parse(Console.ReadLine());

            //Take the number the user provided and cast it as ClassicMonsters
            Classicmonsters monster = (Classicmonsters)userInput;

            switch (monster)
            {
                case Classicmonsters.Dracula:
                    Console.WriteLine();
                    //Unlimited number of lines of codes here
                    break;
                case Classicmonsters.Chupacabra:
                    Console.WriteLine();
                    break;
                case Classicmonsters.Frakenstein:
                    break;

                case Classicmonsters.Mummra:

                    break;
                case Classicmonsters.Godzilla:
                    break;

                case Classicmonsters.SwampThing:
                    break;

                case Classicmonsters.Skeletor:
                    break;


                default:
                    Console.WriteLine();
                    break;

                        














            }

            //WE can also manually assign numeric lookup values for each enum item...

            int birthdayMonth = 11;

            Console.WriteLine("My Birthday is in" + (Months)birthdayMonth);

            Console.WriteLine("November is the " + (int)Months.November + "th month of the year");





       
        
        
        
        
        
        
        }


    }
}
