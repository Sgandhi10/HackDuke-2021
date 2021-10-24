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
    private bool _canAnswer = true;
    // Start is called before the first frame update
    private int counter = 0;

    void Start()
    {
        questions = new QuestionDict();
        Instantiate(Dart, transform.position, Quaternion.identity, this.transform);
        questions.GenerateQuestion();
        updateText();
        this.GetComponentInChildren<Canvas>().GetComponent<Text>().text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void onAnswer(int a)
    {
        if (!_canAnswer) return;
        if (CurrentQuestion.Answer != a)
        {
            // WRONG!!!
            if (!answered)
            {
                Debug.Log("Cringe!");
                this.GetComponentsInChildren<Board>()[a].GetComponents<Board>()[0].SetColor(Color.red);
                this.GetComponentsInChildren<AudioSource>()[1].Play(0);
                StartCoroutine(ExampleCoroutine(a, 1, false));

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
            this.GetComponentsInChildren<AudioSource>()[2].Play(0);
            this.GetComponentsInChildren<Board>()[a].GetComponents<Board>()[0].SetColor(Color.green);
            this.GetComponentInChildren<Canvas>().GetComponent<Text>().text = "Score: " + ++score;
            _canAnswer = false;
            StartCoroutine(ExampleCoroutine(a, 2, true));
            // }
        }
    }
    public void updateText()
    {
        if(Globals.NumQuestions>0 && counter >=Globals.NumQuestions){
            UnityEngine.SceneManagement.SceneManager.LoadScene("EndScreen");
            return;}
        answered = false;
        int i = 0;
        this.GetComponentsInChildren<TextMeshPro>()[0].text = CurrentQuestion.Text;

        foreach (Board o in this.GetComponentsInChildren<Board>())
        {
            o.GetComponentInChildren<TextMeshPro>().text = this.CurrentQuestion.Choices[i++];
        }
        
    }

    IEnumerator ExampleCoroutine(int a, int time, bool correct)
    {
        yield return new WaitForSeconds(time);
        this.GetComponentsInChildren<Board>()[a].GetComponents<Board>()[0].ResetColor();
        if(correct)
            counter++;
        updateText();
        _canAnswer = true;
    }
}
