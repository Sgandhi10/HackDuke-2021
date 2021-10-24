using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionDict
{
    private List<int> left;
    public Question LastQuestion { get; set; }
    private IDictionary<string, string> questions = new Dictionary<string, string>() {
        {"The KISS rule of investing teaches:", "Keep it simple, stupid" },
        {"Which is an example of saving?", "Putting $100 of monthly salary into an interest-bearing account." },
        {"Which is not a good investment?", "Gold" },
        {"What is line of credit?", "An amount someone can borrow on a credit card" },
        {"The risk return ratio says: ", "When the risk goes up, the return generally will go up." },
        {"What is annual percentage rate?", "Interest rate changed per year to a person borrowing money" },
        {"What is credt?", "When goods, services, or money are receiving in exchange for a promise to pay back to a definite sum of money at a future date" },
        {"A savings account with a certificate is a:", "C. D." },
        {"What is a bull market?", "When stock prices go up." },
        {"What is a bear market?", "When stock prices drop 20%+" },
        {"Spreading in investments widely across different industry sectors to reduce risk is called?", "Diversification" },
        {"When making a purchase on credit, the original amount borrowed is called?", "Principal" },
        {"What is the general relationship between risk and return?", "The higher the risk, the higher the return" },
        {"What is the Roth IRA maximum yearly contrbution?", "$6000" },
        {"What is the 401(k) maximum yearly contribution?", "$58,000" },
        {"What is a 401(k)?", "Retirement savings and investment plan provided by employer." },
        {"What is a Roth IRA?", "Individual retirement account usually not taxed upon." },
        {"What is an ETF?", "A security that tracks assets that are sold on the exchange." },
        {"What is a Credit Premium?", "Excess return an investor obtains for holding non-governmental bonds." },
        {"The ease with which an asset can be turned into cash", "Liquidity" },
        {"The purpose of your insurance is to ________ your assets", "Protect" },
        {"What does the opportunity cost of a purchase tell you?", "The cost of the purchase plus the cost of not doing or purchasing something else" },
        {"A nonprofit financial institution that is owned by its members and organized for their benefit", "Credit Union" },
        {"When money is earned on the total amount in the account including the initial deposit and interest that has already been credited to the account", "Compounding Interesting" }};

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
        left.RemoveAll((i) => i == left[rand]);
        string symbol = questions[name];

        string question = name;

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
