using System;
using System.Collections.Generic;
using System.Text;

namespace GradeItLibrary
{
    public sealed class Teacher:Person
    {
        //Membervariables

        private string title;
        private List<Class> classes = new List<Class>();



        //Constructor(s)
        public Teacher(int Id, string FirstName, string LastName, string Email, string Title) : base(Id, FirstName, LastName, Email)
        {
            id = Id;
            firstname = FirstName;
            lastname = LastName;
            email = Email;
            title = Title;
        }

        //Properties
        public string Title { get => title; set => title = value; }
        public List<Class> Classes { get => classes; set => classes = value; }
    }
}
