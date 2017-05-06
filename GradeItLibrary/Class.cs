using System;
using System.Collections.Generic;
using System.Text;

namespace GradeItLibrary
{
    public sealed class Class
    {
        //Membervariables

        private int id;
        private string name;
        private List<Student> students = new List<Student>();

        //Constructor(s)
        public Class(int Id, string Name, List<Student>Students)
        {
            id = Id;
            name = Name;
            students = Students;
        }
        //Properties
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public List<Student> Students { get => students; set => students = value; }
    }
}
