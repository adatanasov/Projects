namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class LocalCourse : Course
    {
        private string lab;

        public LocalCourse(string name)
            : this(name, "Unknown teacher", new List<string>(), "Unknown lab")
        {
        }

        public LocalCourse(string name, string teacherName)
            : this(name, teacherName, new List<string>(), "Unknown lab")
        {
        }

        public LocalCourse(string name, string teacherName, IList<string> students)
            : this(name, teacherName, students, "Unknown lab")
        {
        }

        public LocalCourse(string name, string teacherName, IList<string> students, string lab)
            : base(name, teacherName, students)
        {
            this.Lab = lab;
        }

        public string Lab
        {
            get 
            { 
                return this.lab;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Lab's name can't be null ot empty!");
                }
                else
                {
                    this.lab = value;
                }
            }
        }       

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(base.ToString());
            result.Append("; Lab = ");
            result.Append(this.Lab);
            result.Append(" }");
            return result.ToString();
        }
    }
}
