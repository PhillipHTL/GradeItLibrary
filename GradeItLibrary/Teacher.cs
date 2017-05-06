using System;
using System.Collections.Generic;
using System.Text;

namespace GradeItLibrary
{
    public class Teacher:Person
    {
        public string Title;
        public List<Class> Classes = new List<Class>();

    }
}
