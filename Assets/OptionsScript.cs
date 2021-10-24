using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsScript : MonoBehaviour
{
    // Start is called before the first frame update
    InputField TimeField, NumField;
    public int time = -1;
    public int questions = -1;
    public GameObject MainMenu;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void InfBtn() 
    {
        SubmitButton(-1);
    }
    public void FiveBtn() 
    {
        SubmitButton(5);
    }
    public void TenBtn() 
    {
        SubmitButton(10);
    }
    public void TwentyBtn() 
    {
        SubmitButton(20);
    }
    public void UpdateNumQuestions(int a){
        Globals.NumQuestions = a;
    }
    public void SubmitButton(int a){
        UpdateNumQuestions(a);
        Debug.Log(Globals.NumQuestions);
        UnityEngine.SceneManagement.SceneManager.LoadScene("WelcomeScene");
    }
}
