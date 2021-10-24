using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainScript : MonoBehaviour
{
    List<Question> questions;
    int currIndex = 0;
    public Question CurrentQuestion { get => questions[currIndex]; }
    public GameObject Dart;
    public bool answered = false;
    // Start is called before the first frame update
    void Start()
    {
        questions = new List<Question>();
        currIndex = 0;
        questions.Add(new Question("Chemical formula for sodium hydroixide?", new string[] { "SoHo", "NaBr", "LiOH", "NaOH" }, 3));
        questions.Add(new Question("Chemical formula for bicarbonate ion?", new string[] { "HCO3 1-", "HClO4", "H2O", "HCO2 1-" }, 0));
        questions.Add(new Question("Chemical formula for hydrochloric acid?", new string[] { "HBr", "HCl", "H2SO4", "HCl2" }, 1));

        questions.Add(new Question("What is the oxidation number of sulfur in sulfate?", new string[] { "+2", "-4", "+6", "-8" }, 2));
        Instantiate(Dart, transform.position, Quaternion.identity, this.transform);
        updateText();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void onAnswer(int a)
    {

        if (currIndex <= questions.Count && questions[currIndex].Answer != a)
        {
            // WRONG!!!
            if(!answered){
                Debug.Log("Cringe!");
                this.GetComponentsInChildren<Board>()[a].GetComponents<Board>()[0].SetColor(Color.red);
                StartCoroutine(ExampleCoroutine(a, 1));
            }
            

        }
        else
        {
            currIndex++;
            answered = true;
            if (currIndex == questions.Count)
            {
                // DONE!!!
                this.GetComponentsInChildren<TextMeshPro>()[0].text = "u r smat";
                for(int i = 0; i<4; i++){
                    this.GetComponentsInChildren<Board>()[a].GetComponents<Board>()[0].SetColor(Color.green);}
            }
            else
            {
                Debug.Log("Hit target!" + a);
                Debug.Log("Hit target!" + a);
                Debug.Log("Hit target!" + a);
                Debug.Log("Hit target!" + a);
                Debug.Log("Hit target!" + a);
                Debug.Log("Hit target!" + a);
                this.GetComponentsInChildren<Board>()[a].GetComponents<Board>()[0].SetColor(Color.green);
                this.GetComponentInChildren<Canvas>().GetComponent<Text>().text = "Score: " + (currIndex);
                StartCoroutine(ExampleCoroutine(a, 2));

            }
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
