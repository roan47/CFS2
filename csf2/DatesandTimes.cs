//namespace - directory/folder for the file
namespace Block1
{
    //class - the file itself
    class DatesAndTimes
    {
        //static void Main() - where to start/place code to execute
        // svm > Tab > Tab
        static void Main(string[] args)
        {
            //cw > Tab > Tab
            Console.WriteLine("DateTime Datatype");
            Console.Title = "Dates and Times";

            //region > Tab > Tab
            #region DateTime Notes

            /*
             * DateTime is a class from the framework that we can use as 
             * a datatype to create variables that hold date & time information.
             * 
             * Time defaults to 12:00 a.m.
             * 
             * This is an example of a complex data type, unlike bools, ints, strings, 
             * etc, which are all intrinsic data types.
             * 
             * Complex data types often need the "new" keyword and a "constructor" method,
             * which has the same name as that data type.
             * 
             * One example we've already seen for a complex type:
             * string[] colors = new string[5];
             * 
             * Syntax for DateTime:
             * DateTime x = new DateTime();
             * 
             * Additionally, you can use "format specifiers" with DateTime objects.
             * Examples: (d, D, M, t, T, f, F)
             */

            #endregion

            DateTime graduationDay = new DateTime(2022, 7, 5);

            Console.WriteLine("Graduation day is {0} with no formatting", graduationDay);
            //ctrl + D = Duplicate line
            Console.WriteLine("Graduation day is {0:d} as a short date.", graduationDay);
            Console.WriteLine("Graduation day is {0:D} as a long date.", graduationDay);
            Console.WriteLine("Graduation day is {0:M} with month-day format.", graduationDay);
            Console.WriteLine("Graduation day is {0:t} as a short time.", graduationDay);
            Console.WriteLine("Graduation day is {0:T} as a long time.", graduationDay);
            Console.WriteLine("Graduation day is {0:f} as a short full datetime.", graduationDay);
            Console.WriteLine("Graduation day is {0:F} as a long full datetime.", graduationDay);


            DateTime myBday = new DateTime(1976, 09, 30);
            Console.WriteLine("Birthday was {0:D}", myBday);

            //Let's find 7 days after your birthday
            //DateTime weekAfterDate = myBday + 7; - Can't add a DateTime and int

            //DateTime weekAfterDate = new DateTime(1976, 09, 30 + 7);
            //Console.WriteLine("7 days later: {0:d}", weekAfterDate);
            //The above approach works in some cases, but will fail if it returns
            //a date that does not exist (Sept. 37th)

            DateTime weekAfterDate = myBday.AddDays(7);
            Console.WriteLine("7 Days later: {0:D}", weekAfterDate);

            Console.WriteLine("3 days earlier: {0:D}", myBday.AddDays(-3));
            //The Subtract() doesn't work here because it needs a timespan to work with
            //So, we can use AddDays() with a negative number to subtract from the date

            //You can determine the current date (DateTime.Today) or 
            //the current date and time (DateTime.Now)

            //This is SUPER useful when logging changes in your application (timestamps)

            Console.WriteLine("Current date dynamically generated {0:D}", DateTime.Today);
            Console.WriteLine("Current full date and time {0:F}", DateTime.Now);

            DateTime myNextBday = new DateTime(2022, 09, 23);
            Console.WriteLine("Time remaining until your next birthday: " +
                "{0:dd\\ hh\\:mm\\:ss}\n", DateTime.Now.Subtract(myNextBday));

            //Timespan objects are very useful for determining the amount of time 
            //between two DateTime objects

            //How long was this worker clocked in?
            DateTime clockedIn = new DateTime(2013, 10, 17, 20, 30, 0);
            DateTime clockedOut = new DateTime(2013, 10, 18, 4, 31, 1);

            TimeSpan timeWorked = clockedOut.Subtract(clockedIn);

            Console.WriteLine("\nThe worker was on the clock for {0} hours and {1} minute{2}",
                timeWorked.Hours, timeWorked.Minutes, timeWorked.Minutes == 1 ? "" : "s");


            Console.WriteLine("All code has been executed. Press any key to exit.");
            Console.ReadKey(true);
        }
    }
}