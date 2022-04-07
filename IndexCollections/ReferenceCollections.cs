using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; //added for easy access to non generic collections

namespace BLock3
{
    internal class ReferenceCollections
    {
        static void Main(string[] args)
        {
            #region Notes - Reference Collection

            /* 
             * Reference type collections store what is called key/value pairs.
             * 
             * These types of collections are best suited for large collections
             * where the order of entry and/or the indexed value don't matter.
             * 
             * 
             * The key is a value that can uniquely identify an item in the collection.
             * 
             * for example, a student ID could uniquely identify a student record.
             * 
             * The Value is the entire object that is being stored.
             * 
             * Collection Initialization is availble.
             * 
             * For Hashtables, the holding type is dictionary entry - both the key and the value go in that tyhpe of object
             * 
             *For dictiionary the holding type is KeyValuePair - both the KEY AND THE VALUE  are strongly typed in  this collection
             *
             * 
             * 
             * 
             */

            #endregion

            #region Employee Objects
            //Create 5 employee Objects

            Employee e1 = new Employee(111, "Mike", "Baxter", "Marketing Genius", new DateTime(2011, 1, 1), true);
            Employee e2 = new Employee(222, "Kris", "Baxter", "Restuarant Manager", new DateTime(2012, 2, 2), false);
            Employee e3 = new Employee(333, "Ed", "Alzate", "Business Owner", new DateTime(2013, 3, 3), true);
            Employee e4 = new Employee(444, "Kyle", "Seamore", "Gopher", new DateTime(2011, 1, 1), false);
            Employee e5 = new Employee(555, "Chuck", "Larabee", "Security Manager", new DateTime(2011, 1, 1), true);

            #endregion

            Console.WriteLine("\n\nEmployees Hashtable\n\n");

            Hashtable emps = new Hashtable()
            {
                // { Key (unique), Value (entire object) }
                { e1.ID, e1 },
                { e2.ID, e2 },
                { e3.ID, e3 },
                { e4.ID, e4 },






            };

            //Add () is available for Hashtables as well
            emps.Add(e5.ID, e5);

            //Loop through the Hashtable
            foreach (DictionaryEntry entry in emps)
            {
                Console.WriteLine(entry.Value);
                Console.WriteLine("-=-=-=-=-==-=-=-=-=-==-=-=-=-=-=-\n");

            }

            //Loop through the Hashtable and output ONLY the first name
            Console.WriteLine("\n\nEmployee First Name\n\n");

            foreach (DictionaryEntry entry in emps)
            {
                //In order to access specific properties, we need to UNBOX the objects
                Employee e = (Employee)entry.Value;
                Console.WriteLine(e.FirstName);

            }
            //We can still remove objects from Hashtables
            emps.Remove(e5.ID);


            //What about accessing a specific property of the object that has been removed?
          //Console.WriteLine(((Employee)emps[e5.ID]).FirstName);

            //Null Reference Exception: object reference not set to an instance of an object

            //Now let's take a look at Dictionaries
            //Syntax: Dictionary<TKEY, TValue>
            Dictionary<int, Employee> emps2 = new Dictionary<int, Employee>()
            {
                { e1.ID, e1 },
                { e2.ID, e2 },
                { e3.ID, e3 },
                { e4.ID, e4 },

            };
            Console.WriteLine("\n\nIterate through the Dictionary Collection\n");
           //oreach (KeyValuePair<int, Employee> kvp in emps2)
           //THe above is a specific type of object appropriate for the dictionary.
           //This is great, but in this case its alot of typing, so instead we can just use the generic var type here for brevity.
                foreach (var kvp in emps2)
          {
                Console.WriteLine(kvp.Value.FirstName + " " + kvp.Value.LastName);


            };


            //When were done, we can clear the dictionary as well
            emps2.Clear();



                   






            























        }





    }
}
