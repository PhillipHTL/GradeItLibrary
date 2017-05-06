using System;
using System.Collections.Generic;
using System.Text;

namespace GradeItLibrary
{
    public sealed class Grade
    {
        //Membervariables

        private string id;
        private DateTime date;
        private int gradevalue;
        private string constituentsubject;

        //Constructor(s)
        public Grade(string Id, DateTime Date, int Gradevalue, string Constituentsubject )
        {
            id = Id;
            date = Date;
            gradevalue = Gradevalue;
            constituentsubject = Constituentsubject;
        }

        //Properties
        public string Id { get => id; set => id = value; }
        public DateTime Date { get => date; set => date = value; }
        public int Gradevalue { get => gradevalue; set => gradevalue = value; }
        public string Constituentsubject { get => constituentsubject; set => constituentsubject = value; }
    }
}
