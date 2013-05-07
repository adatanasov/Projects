namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class OffsiteCourse : Course
    {
        private string town;

        public OffsiteCourse(string name)
            : this(name, "Unknown teacher", new List<string>(), "Unknown town")
        {
        }

        public OffsiteCourse(string name, string teacherName)
            : this(name, teacherName, new List<string>(), "Unknown town")
        {
        }

        public OffsiteCourse(string name, string teacherName, IList<string> students)
            : this(name, teacherName, students, "Unknown town")
        {
        }

        public OffsiteCourse(string name, string teacherName, IList<string> students, string town)
            : base(name, teacherName, students)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Town's name can't be null ot empty!");
                }
                else
                {
                    this.town = value;
                }
            }
        }   

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            result.Append("; Town = ");
            result.Append(this.Town);
            result.Append(" }");
            return result.ToString();
        }
    }
}
