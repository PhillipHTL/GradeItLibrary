using System;
using System.Collections.Generic;
using System.Text;

namespace GradeItLibrary
{
    public sealed class Subject
    {
        //Membervariables

        private int id;
        private string name;
        private int nrofperiods;

        //Constructor(s)
        public Subject(int Id, string Name, int Nrofperiods)
        {
            id = Id;
            name = Name;
            nrofperiods = Nrofperiods;
        }
        //Properties
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Nrofperiods { get => nrofperiods; set => nrofperiods = value; }
    }
}
