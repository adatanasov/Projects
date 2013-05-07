namespace Methods
{
    using System;

    public class Student
    {
        private string firstName, lastName, otherInfo;

        public string FirstName 
        { 
            get
            {
                return this.firstName;
            }

            set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentNullException("First name can't be null or empty!");
                }

                this.firstName = value;
            }
        }

        public string LastName 
        {
            get
            {
                return this.lastName;
            }

            set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentNullException("Last name can't be null or empty!");
                }

                this.lastName = value;
            }
        }

        public string OtherInfo
        {
            get
            {
                return this.otherInfo;
            }

            set
            {
                if (value == null || value == string.Empty)
                {
                    throw new ArgumentNullException("Other info can't be null or empty!");
                }

                this.otherInfo = value;
            }
        }

        public bool IsOlderThan(Student other)
        {
            DateTime firstDate;
            DateTime.TryParse(this.OtherInfo.Substring(this.OtherInfo.Length - 10), out firstDate);
            DateTime secondDate;
            DateTime.TryParse(other.OtherInfo.Substring(other.OtherInfo.Length - 10), out secondDate);
            if (firstDate == null)
            {
                throw new ArgumentNullException("The date of birth of the first student can't be parsed!");
            }

            if (secondDate == null)
            {
                throw new ArgumentNullException("The date of birth of the second student can't be parsed!");
            }

            return firstDate < secondDate;
        }
    }
}
