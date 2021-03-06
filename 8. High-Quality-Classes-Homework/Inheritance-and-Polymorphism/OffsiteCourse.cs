﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceAndPolymorphism
{
    public class OffsiteCourse : Course
    {
        public string Town { get; set; }

        public OffsiteCourse(string courseName)
            : this(courseName, String.Empty, new List<string>(), String.Empty)
        {
        }

        public OffsiteCourse(string courseName, string teacherName)
            : this(courseName, teacherName, new List<string>(), String.Empty)
        {

        }

        public OffsiteCourse(string courseName, string teacherName, IList<string> students)
            : this(courseName, teacherName, students, String.Empty)
        {

        }
        
        public OffsiteCourse(string courseName, string teacherName, IList<string> students, string town)
            : base(courseName, teacherName, students)
        {
            this.Town = town;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            if (this.Town != String.Empty)
            {
                result.Append("; Town = ");
                result.Append(this.Town);
            }
            result.Append(" }");
            return result.ToString();
        }
    }
}
