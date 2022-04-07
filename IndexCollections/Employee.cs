using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLock3


{

    //Defaults to interal -- change to acess to public
    public class Employee

   {
        //FIELDS
        //Always private
        //Naming convention: _camelCase;
        private int _id;
        private string _firstName;
        private string _lastName;
        private string _jobTitle;
        private DateTime _dateofHire;
        private bool _isDirectDeposit;

        //PROPERTIES
        //Always public
        //Naming convention: PascalCase
        public int ID
        {
            get { return _id; }
            set { _id = value; }

        }
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }

        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }

        }
        public string JobTitle
        {
            get { return _jobTitle; }
            set { _jobTitle = value; }

        }
        public DateTime DateOfHire
        {
                get { return _dateofHire; }
            set { _dateofHire = value; }

        }
        public bool IsDirectDeposit
        {
            get {  return _isDirectDeposit;}
            set { _isDirectDeposit = value; }

        }

        //CONSTRUCTORSir
        //ALWAYS oublic
        //Must have the same name as the class
        public Employee(int id, string fName, string lName, string title, DateTime hireData, bool isDirectDeposit)
        {
            ID = id;
            FirstName = fName;
            LastName = lName;
            JobTitle = title;
                DateOfHire = hireData;
            IsDirectDeposit = isDirectDeposit;

        }
        //METHODS 
        //Overrude the ToString()
        public override string ToString()
        {
            return string.Format($"ID: {ID}\nName: {FirstName}, {LastName}\nTitle: {JobTitle}\n" +
                $"Hire Date: {DateOfHire:d}\n" +

                //Ternary Operator: 3 Parts
                //Condition ? ifTrue : ifFalse
                $"Direct Deposit: {(IsDirectDeposit ? "Enabled" : "Disabled")}");
        }




    }
}
