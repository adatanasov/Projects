using System;

public class ExamResult
{
    private int grade;
    private int minGrade;
    private int maxGrade;
    private string comments;

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade
    {
        get 
        { 
            return this.grade; 
        }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Grade", "Grade must be equal or bigger than zero!");
            }
            else
            {
                this.grade = value; 
            }
        }
    }

    public int MinGrade
    {
        get
        {
            return this.minGrade;
        }

        private set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Min grade", "Min grade must be equal or bigger than zero!");
            }
            else
            {
                this.minGrade = value;
            }
        }
    }

    public int MaxGrade
    {
        get
        {
            return this.maxGrade;
        }

        private set
        {
            if (value <= this.MinGrade)
            {
                throw new ArgumentOutOfRangeException("Max grade", "Max grade must be bigger than min grade!");
            }
            else
            {
                this.maxGrade = value;
            }
        }
    }

    public string Comments
    {
        get
        {
            return this.comments;
        }

        private set
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentNullException("Comments", "Comments can't be null or empty!");
            }
            else
            {
                this.comments = value;
            }
        }
    }
}
