using System;
using System.Collections.Generic;

namespace GradeItLibrary
{
    public abstract class Person
    {
        //Membervariables
        internal int id;
        internal string firstname;
        internal string lastname;
        internal string email;

        //Constructor(s)
        protected Person(int Id, string FirstName, string LastName, string Email)
        {
            id = Id;
            firstname = FirstName;
            lastname = LastName;
            email = Email;
        }

       
    }




    


}
