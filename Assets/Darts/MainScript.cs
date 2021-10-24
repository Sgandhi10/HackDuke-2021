using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainScript : MonoBehaviour
{
    QuestionDict questions;
    public Question CurrentQuestion { get => questions.LastQuestion; }
    public GameObject Dart;
    public bool answered = false;
    private int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        questions = new QuestionDict();
        Instantiate(Dart, transform.position, Quaternion.identity, this.transform);
        questions.GenerateQuestion();
        updateText();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void onAnswer(int a)
    {

        if (CurrentQuestion.Answer != a)
        {
            // WRONG!!!
            if (!answered)
            {
                Debug.Log("Cringe!");
                this.GetComponentsInChildren<Board>()[a].GetComponents<Board>()[0].SetColor(Color.red);
                StartCoroutine(ExampleCoroutine(a, 1));
            }


        }
        else
        {
            answered = true;
            questions.GenerateQuestion();
            // if (currIndex == questions.Count)
            // {
            //     // DONE!!!
            //     this.GetComponentsInChildren<TextMeshPro>()[0].text = "u r smat";
            //     for (int i = 0; i < 4; i++)
            //     {
            //         this.GetComponentsInChildren<Board>()[a].GetComponents<Board>()[0].SetColor(Color.green);
            //     }
            // }
            // else
            // {
                Debug.Log("Hit target!" + a);
                this.GetComponentsInChildren<Board>()[a].GetComponents<Board>()[0].SetColor(Color.green);
                this.GetComponentInChildren<Canvas>().GetComponent<Text>().text = "Score: " + score++;
                StartCoroutine(ExampleCoroutine(a, 2));

            // }
        }
    }
    public void updateText()
    {
        answered = false;
        int i = 0;
        this.GetComponentsInChildren<TextMeshPro>()[0].text = CurrentQuestion.Text;

        foreach (Board o in this.GetComponentsInChildren<Board>())
        {
            o.GetComponentInChildren<TextMeshPro>().text = this.CurrentQuestion.Choices[i++];
        }
    }

    IEnumerator ExampleCoroutine(int a, int time)
    {
        yield return new WaitForSeconds(time);
        this.GetComponentsInChildren<Board>()[a].GetComponents<Board>()[0].ResetColor();

        updateText();

    }
}
