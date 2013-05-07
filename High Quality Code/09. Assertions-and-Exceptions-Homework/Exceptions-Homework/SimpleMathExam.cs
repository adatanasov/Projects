using System;

public class SimpleMathExam : Exam
{
    private const int MinimalProblemsSolved = 0;
    private const int MaximalProblemsSolved = 10;
    private int problemsSolved;

    public SimpleMathExam(int solvedProblems)
    {
        this.ProblemsSolved = solvedProblems;
    }

    public int ProblemsSolved 
    {
        get
        {
            return this.problemsSolved;
        }

        private set
        {
            if (value < MinimalProblemsSolved || value > MaximalProblemsSolved)
            {
                throw new ArgumentOutOfRangeException("problemsSolved", "Solved problems must be between 0 and 10!");
            }
            else
            {
                this.problemsSolved = value;
            }
        }
    }

    public override ExamResult Check()
    {
        if (this.ProblemsSolved == MinimalProblemsSolved)
        {
            return new ExamResult(2, 2, 6, string.Format("Bad result: {0} problems done.", this.ProblemsSolved));
        }
        else if (this.ProblemsSolved >= 1 && this.ProblemsSolved <= (MaximalProblemsSolved / 2))
        {
            return new ExamResult(4, 2, 6, string.Format("Average result: {0} problems done.", this.ProblemsSolved));
        }
        else
        {
            return new ExamResult(6, 2, 6, string.Format("Excelent result: {0} problems done.", this.ProblemsSolved));
        }
    }
}
