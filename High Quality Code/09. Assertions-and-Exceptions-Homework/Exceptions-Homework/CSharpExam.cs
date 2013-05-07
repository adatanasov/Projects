﻿using System;

public class CSharpExam : Exam
{
    private int score;

    public CSharpExam(int score)
    {
        this.Score = score;
    }

    public int Score 
    {
        get 
        {
            return this.score;
        }

        private set 
        {
            if (value < 0 || value > 100)
            {
                throw new ArgumentOutOfRangeException("Score", "Score must be between 0 and 100!");
            }
            else
            {
                this.score = value;
            }
        } 
    }

    public override ExamResult Check()
    {
        return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
    }
}
