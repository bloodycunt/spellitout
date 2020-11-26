/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class ValueScript : MonoBehaviour
{
        public Button Btn1Correct;
        public Button Btn1Wrong1;
        public Button Btn1Wrong2;
        public Button Btn2Correct;
        public Button Btn2Wrong1;
        public Button Btn2Wrong2;
        public Button Btn3Correct;
        public Button Btn3Wrong1;
        public Button Btn3Wrong2;
        public int Sentence1;
        public int Sentence2;
        public int Sentence3;
        public int FinalScoreRecipe1;
        public Text ScoreTxt;

    public void Start()
    {
        //sentence 1 buttons
        Button CorrectSentence1 = Btn1Correct.GetComponent<Button>();
        Button Wrong1Sentence1 = Btn1Wrong1.GetComponent<Button>();
        Button Wrong2Sentence1 = Btn1Wrong2.GetComponent<Button>();

        CorrectSentence1.onClick.AddListener(CorrectClicked1);
        Wrong1Sentence1.onClick.AddListener(Wrong1Clicked1);
        Wrong2Sentence1.onClick.AddListener(Wrong2Clicked1);

        //sentence 2 buttons
        Button CorrectSentence2 = Btn2Correct.GetComponent<Button>();
        Button Wrong1Sentence2 = Btn2Wrong1.GetComponent<Button>();
        Button Wrong2Sentence2 = Btn2Wrong2.GetComponent<Button>();

        CorrectSentence2.onClick.AddListener(CorrectClicked2);
        Wrong1Sentence2.onClick.AddListener(Wrong1Clicked2);
        Wrong2Sentence2.onClick.AddListener(Wrong2Clicked2);

        //sentence 3 buttons
        Button CorrectSentence3 = Btn3Correct.GetComponent<Button>();
        Button Wrong1Sentence3 = Btn3Wrong1.GetComponent<Button>();
        Button Wrong2Sentence3 = Btn3Wrong2.GetComponent<Button>();

        CorrectSentence3.onClick.AddListener(CorrectClicked3);
        Wrong1Sentence3.onClick.AddListener(Wrong1Clicked3);
        Wrong2Sentence3.onClick.AddListener(Wrong2Clicked3);

    }

    void Update()
    {
        FinalScoreRecipe1 = Sentence1 + Sentence2 + Sentence3;
        ScoreTxt.text = "Score: " + FinalScoreRecipe1;
    }

    void CorrectClicked1()
    {
        // sentence 1 get value correct
        ButtonHandler CorrectScript1 = Btn1Correct.GetComponent<ButtonHandler>();
        Debug.Log(CorrectScript1.value);
        Sentence1 = CorrectScript1.value;
    }

    void CorrectClicked2()
    {
        // sentence 2 get value correct
        ButtonHandler CorrectScript2 = Btn2Correct.GetComponent<ButtonHandler>();
        Debug.Log(CorrectScript2.value);
        Sentence2 = CorrectScript2.value;
    }

    void CorrectClicked3()
    {
        // sentence 3 get value correct
        ButtonHandler CorrectScript3 = Btn3Correct.GetComponent<ButtonHandler>();
        Debug.Log(CorrectScript3.value);
        Sentence3 = CorrectScript3.value;
    }

    void Wrong1Clicked1()
    {
        // sentence 1 get value wrong 1
        ButtonHandler Wrong1Script1 = Btn1Wrong1.GetComponent<ButtonHandler>();
        Debug.Log(Wrong1Script1.value);
        Sentence1 = Wrong1Script1.value;
    }

    void Wrong1Clicked2()
    {
        // sentence 2 get value wrong 1
        ButtonHandler Wrong1Script2 = Btn2Wrong1.GetComponent<ButtonHandler>();
        Debug.Log(Wrong1Script2.value);
        Sentence2 = Wrong1Script2.value;
    }

    void Wrong1Clicked3()
    {
        // sentence 3 get value wrong 1
        ButtonHandler Wrong1Script3 = Btn3Wrong1.GetComponent<ButtonHandler>();
        Debug.Log(Wrong1Script3.value);
        Sentence3 = Wrong1Script3.value;
    }

    void Wrong2Clicked1()
    {
        // sentence 1 get value wrong 2
        ButtonHandler Wrong2Script1 = Btn1Wrong2.GetComponent<ButtonHandler>();
        Debug.Log(Wrong2Script1.value);
        Sentence1 = Wrong2Script1.value;
    }

    void Wrong2Clicked2()
    {
        // sentence 2 get value wrong 2
        ButtonHandler Wrong2Script2 = Btn2Wrong2.GetComponent<ButtonHandler>();
        Debug.Log(Wrong2Script2.value);
        Sentence2 = Wrong2Script2.value;
    }

    void Wrong2Clicked3()
    {
        // sentence 3 get value wrong 2
        ButtonHandler Wrong2Script3 = Btn3Wrong2.GetComponent<ButtonHandler>();
        Debug.Log(Wrong2Script3.value);
        Sentence3 = Wrong2Script3.value;
    }
}*/
