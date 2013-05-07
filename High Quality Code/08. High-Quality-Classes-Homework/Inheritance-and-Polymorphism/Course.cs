namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Course
    {
        //// FIELDS
        private string name;
        private string teacherName;
        private IList<string> students;

        //// CONSTRUCTORS
        public Course(string name) 
            : this(name, "Unknown teacher", new List<string>())
        {
        }

        public Course(string name, string teacherName)
            : this(name, teacherName, new List<string>())
        {
        }

        public Course(string name, string teacherName, IList<string> students)
        {
            this.Name = name;
            this.TeacherName = teacherName;
            this.Students = students;
        }

        //// PROPERTIES
        public IList<string> Students
        {
            get 
            { 
                return this.students; 
            }

            set 
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Students' list can't be null!");
                }
                else
                {
                    this.students = value;
                }
            }
        }        

        public string TeacherName
        {
            get
            {
                return this.teacherName;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Teacher's name can't be null ot empty!");
                }
                else
                {
                    this.teacherName = value;
                }
            }
        }       

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Course's name can't be null or empty!");
                }
                else
                {
                    this.name = value;
                }
            }
        }

        //// METHODS
        public string GetStudentsAsString()
        {
            if (this.Students == null || this.Students.Count == 0)
            {
                return "Unknown students";
            }
            else
            {
                return "{ " + string.Join(", ", this.Students) + " }";
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append(this.GetType().Name);
            result.Append(" { Name = ");
            result.Append(this.Name);
            result.Append("; Teacher = ");
            result.Append(this.TeacherName);            
            result.Append("; Students = ");
            result.Append(this.GetStudentsAsString());
            return result.ToString();
        }
    }
}
