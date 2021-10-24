using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question 
{
    private string question;
    private string answerA, answerB, answerC, answerD;
    private char c_answer;

    public bool check(char answer)
    {
        return answer == c_answer;
    }
        
    public Question(string question, string answerA, string answerB, string answerC, string answerD, char c_answer)
    {
        this.question = question;
        this.answerA = answerA;
        this.answerB = answerB;
        this.answerC = answerC;
        this.answerD = answerD;
        this.c_answer = c_answer;
    }
    public string get_aA()
    {
        return answerA;
    }
    public string get_aB()
    {
        return answerB;
    }
    public string get_aC()
    {
        return answerC;
    }
    public string get_aD()
    {
        return answerD;
    }
    public string get_question()
    {
        return question;
    }
    public char get_cA()
    {
        return c_answer;
    }
}
