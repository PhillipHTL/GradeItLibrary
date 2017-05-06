using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace GradeItLibrary
{
    public sealed class Student : Person
    {
        //Membervariables

        private List<Grade> grades = new List<Grade>();

        //Constructor(s)
        public Student(int Id, string FirstName, string LastName, string Email, List<Grade>Grades) : base(Id, FirstName, LastName, Email)
        {
            grades = Grades;
            id = Id;
            firstname = FirstName;
            lastname = LastName;
            email = Email;
            
        }

        //Properties
        public List<Grade> Grades { get => Grades; set => Grades = value; }
        //Method(s)
        private int CalcGPA(ref List<Grade> grades)
        {
            return 0;
        }

    }
    
}
