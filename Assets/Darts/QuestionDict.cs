using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionDict
{
    private List<int> left;
    public Question LastQuestion { get; set; }
    private IDictionary<string, string> questions = new Dictionary<string, string>() {
        {"Bicarbonate ion", "HCO3 1-" },
        {"Acetate ion", "C2H3O2 1-" },
        {"Nitrate ion", "NO3 1-" },
        {"Nitrite ion", "NO2 1-" },
        {"Permanganate ion", "MnO4 1-" },
        {"Cyanide ion", "CN 1-" },
        {"Cyanate ion", "OCN 1-" },
        {"Hydroxide ion", "OH 1-" },
        {"Perchlorate ion", "ClO4 1-" },
        {"Chlorate ion", "ClO3 1-" },
        {"Chlorite ion", "ClO2 1-" },
        {"Hypochlorite ion", "ClO 1-" },
        {"Ammonium ion", "NH4 1+" },
        {"Selenate ion", "SeO4 2-" },
        {"Tellurate ion", "TeO4 2-" },
        {"Carbonate ion", "CO3 2-" },
        {"Sulfate ion", "SO4 2-" },
        {"Sulfite ion", "SO3 2-" },
        {"Thiosulfate ion", "S2O3 2-" },
        {"Peroixide ion", "O2 2-" },
        {"Chromate ion", "CrO4 2-" },
        {"Dichromate ion", "Cr2O7 2-" },
        {"Oxalate", "C2O4 2-" },
        {"Phosphate ion", "PO4 3-" }
    };

    public QuestionDict()
    {

        // List<string> answerChoices = new List<string>();
        // answerChoices.Add(symbol);
        // while(answerChoices.Count < 5)
        // {
        //     rand = Random.Range(0, keyList.Count);
        //     if (answerChoices.Contains(questions[keyList[rand]]) == false){
        //         answerChoices.Add(questions[keyList[rand]]);
        //     }
        // }
        // List<string> ind_char = new List<string>();
        // ind_char.Add("A");
        // ind_char.Add("B");
        // ind_char.Add("C");
        // ind_char.Add("D");
        // rand = Random.Range(1, 5);
        // answerChoices[rand] = answerChoices[0];
        // this.answerA = answerChoices[1];
        // this.answerB = answerChoices[2];
        // this.answerC = answerChoices[3];
        // this.answerD = answerChoices[4];
        // this.c_answer = ind_char[rand-1];
        left = new List<int>();
        for (int i = 0; i < questions.Count; i++)
        {
            left.Add(i);
        }
    }

    public Question GenerateQuestion()
    {
        List<string> keyList = new List<string>(this.questions.Keys);

        if (left.Count == 0)
        {
            for (int i = 0; i < questions.Count; i++)
            {
                left.Add(i);
            }
        }
        int rand = Random.Range(0, left.Count);

        string name = keyList[left[rand]];
        left.Remove(rand);
        string symbol = questions[name];

        string question = "Chemical Equation of " + name + "?";

        List<string> list = new List<string>();
        list.Add(symbol);
        for (int i = 1; i < 4; i++)
        {
            int index = Random.Range(0, questions.Count);
            string temp = questions[keyList[index]];
            while (index == rand || list.Contains(temp))
            {
                index = Random.Range(0, questions.Count);
                temp = questions[keyList[index]];
            }
            list.Add(temp);
        }
        string[] arr = Randomize(list.ToArray());
        int ans = 0;
        for (int j = 0; j < 4; j++)
        {
            if (arr[j].Equals(symbol))
            {
                ans = j;
                break;
            }
        }
        LastQuestion = new Question(question, arr, ans);
        return LastQuestion;
    }

    private static string[] Randomize(string[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            string temp = arr[i];
            int randomIndex = Random.Range(i, arr.Length);
            arr[i] = arr[randomIndex];
            arr[randomIndex] = temp;
        }
        return arr;
    }
}
