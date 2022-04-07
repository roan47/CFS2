using System.Collections;

namespace Block3  
{

    class IndexedCollections // ArrayList
    {

        static void Main(string[] args)
        {
            #region
            /*
             *Collections are groups if ibjects stored together under one name.
             *Some examples: Array [], ArrayList[], or List <T>
             *All of these collections store data that can be retreived using an index number.
             *Additionally, some of these collections types are Generic, meaning they are type safe.
             *The opposite is non generic, which means it is NOT type safe.
             *
             *Array:
             * -Type safe (any type, but only one typer per array) / Generic
             * - Length is fixed at declaration (NOT expandable & cannot change later in the code)
             * 
             * ArrayList:
             * - NOT Type Safe - Non-Generic
             * - It can store values of any datatype into any index of the collections.
             * -Mixing datatypes is acceptable.
             * -To accompliosh this,ArrayList implicitly casts all items as Objects.
             *   - This is called BOXING.
             *   - To USE the values in the ArrayList as their original datatype, you
             *   need to explicitly cast them bacm to their original type. This is UNBOXING.
             * - LENGTH IS expandable (we CAN add/remove items after creating the collection)
             * - Namespace; System.Collections
             * 
             * List (a.k.a. TypedList or List <T>)
             * - Type Safe (just like arrays) / Generic
             * - Expandable (CAN add/remove items after creation)
             *
             * 
             * 
             * 
             * 
             */
            #endregion

            //A quick refresher  on using arrays
            string[] colors = { "red", "green", "blue", "purple" };

            Console.WriteLine("\n***** ARRAYS *****\n");

          //  Console.WriteLine(colors[0]);
          //  Console.WriteLine(colors[1]);   
          //  Console.WriteLine(colors[2]);
          //  Console.WriteLine(colors[3]);
          //  Console.WriteLine(colors[4]);

            //for each loop -- designed specifically to work with collections
            foreach (string color in colors)
            {
                Console.WriteLine(color);

            }

            //Array Lists
            Console.WriteLine("\n***** ARRAYS *****\n");
            ArrayList alist = new ArrayList();

            alist.Add("Triforce");

            //The above *looks* like a string is being added to the ArrayList.
            //However, what's actually happenig is that our string value is 
            //being implicitly cast as an Object, which is then added to alist.
            //ALL values added to an ArrayList will be implicitly cast & stored
            // as Objectsn in this way.
            alist.Add(42); //int will be stored as an Object
            DateTime newyears = new DateTime(2022, 1, 1);
            alist.Add(newyears); //DateTime will be stored as an Object

            //  Console.WriteLine(alist[1]*2);
            //This is a downside to using ArrayList. We gets LOTS of flexibility
            //With what we can store because everything is cast & stored as an Object.
            //But, when we try to us those stored values, they are no longer accessible
            //as their specific tyoes. WE will need to cast them back to their original,
            //more specific types to perform any operations.

            //This process is called UNBOXING. Essentially, We took a small, specific
            //type (int, DateTime, string, etc.) and stored it in a muchh larger type
            //(Object). We can treat this like taking a small box and putting it into
            // a larger one. so, to do things with a smaller box, we need tio UNBOX IT
            // from the larger one first.

            Console.WriteLine((int)alist[1] * 2);

            Console.WriteLine("{0:d}",(DateTime) alist[2]);

            string str = ((string)alist[0]).ToUpper();

            Console.WriteLine(str);

            //We can also reasssign indexes, just like we could in a standard array

            alist[0] = str;

            //Insert() lets us add values to the collection at a specified index
            alist.Insert(1, "Ganon");

            //Alternatively, we still have access to Add(), which will add the new value to the end.
            alist.Add("Tingle");

            //Loop through the ArrayList to output the alist items
             //Counter // Condition // Update 
            for (int i = 0; i < alist.Count; i++)
            {
                Console.WriteLine(alist[i] + " is at the index of" + i);



            }

            Console.WriteLine("\n\n***** TYPED LIST ******\n\n");

            //Typed Lists are type safe (like Arrays) but also expandable (like ArrayLists)
            //Syntax: List<datatype> listName= new list<datatype>();

            List<int> scores = new List<int>();
            scores.Add(12);
            scores.Add(29);
            scores.Add(0);
            scores.Add(44);
            scores.Add(100);

            //We can also add int objects to a List<int>, not just literal ints
            int x = 1000;
            scores.Add(x);

            //We have the ability to sort typed lists, which is an INSTANCE method
            // when using a TypedList or ArrayList. For Arrays, we use a STATIC method.
            //Example: listName.Sort();        VS            Array.Sort(arrayName);

            scores.Sort();

            foreach (int score in scores)
            {
                Console.WriteLine(score);

            }

            //Count shows the current number of items stored in the list:
            Console.WriteLine(scores.Count);

            //We also have access to Insert(), which adds a list item at a specified index
            scores.Insert(3, 99);

            //Like Insert(), we can use RemoveAt() to remove an object at the specified index
            scores.RemoveAt(2);

            foreach (int item in scores)
            {
                Console.WriteLine(scores);

            }

            Console.WriteLine(scores.Count);


            //GENERIC VS NON-GENERIC
            //GENERIC collections ARE strongly typed, whereas non-generic collections store values as Objects








                




        }
    }
}