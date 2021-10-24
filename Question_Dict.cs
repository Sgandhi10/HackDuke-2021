using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Question_Dict
{
    private string question;
    private string answerA, answerB, answerC, answerD;
    private char c_answer;
    private var questions = new Dictionary<string, string>() {
        {"Bicarbonate ion": "HCO3 1-" },
        {"Acetate ion": "C2H3O2 1-" },
        {"Nitrate ion": "NO3 1-" },
        {"Nitrite ion": "NO2 1-" },
        {"Permanganate ion": "MnO4 1-" },
        {"Cyanide ion": "CN 1-" },
        {"Cyanate ion": "OCN 1-" },
        {"Hydroxide ion": "OH 1-" },
        {"Perchlorate ion", "ClO4 1-" },
        {"Chlorate ion": "ClO3 1-" },
        {"Chlorite ion": "ClO2 1-" },
        {"Hypochlorite ion": "ClO 1-" },
        {"Ammonium ion": "NH4 1+" },
        {"Selenate ion": "SeO4 2-" },
        {"Tellurate ion": "TeO4 2-" },
        {"Carbonate ion": "CO3 2-" },
        {"Sulfate ion": "SO4 2-" },
        {"Sulfite ion": "SO3 2-" },
        {"Thiosulfate ion": "S2O3 2-" },
        {"Peroixide ion": "O2 2-" },
        {"Chromate ion": "CrO4 2-" },
        {"Dichromate ion": "Cr2O7 2-" },
        {"Oxalate": "C2O4 2-" },
        {"Phosphate ion": "PO4 3-" }
    };
    

    public bool check(char answer)
    {
        return answer == c_answer;
    }

    public Question_Dict(string question, string answerA, string answerB, string answerC, string answerD, char c_answer)
    {
        List<string> keyList = new List<string>(this.questions.Keys);
        Random rnd = new Random();
        int rand = rnd.Next(0, keyList.length);
        string name = keyList[rand]
        string symbol = questions[name];

        this.question = "Chemical Symbol of " + name + "?";

        List<string> answerChoices = new List<string>();
        answerChoices.Add(symbol);
        while(answerChoices.length < 5)
        {
            rand = rnd.Next(0, keyList.length);
            if (answerChoice.Contains(questions[keyList[rand]] == false){
                answerChoices.Add(questions[keyList[rand]]);
            }
        }
        List<string> ind_char = new List<string>();
        ind_char.Add("A");
        ind_char.Add("B");
        ind_char.Add("C");
        ind_char.Add("D");
        rand = rnd.Next(1, 5);
        answerChoices[rand] = answerChoices[0]
        this.answerA = answerChoices[1];
        this.answerB = answerChoices[2];
        this.answerC = answerChoices[3];
        this.answerD = answerChoices[4];
        this.c_answer = ind_char[rand-1];
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
