using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Recipe : MonoBehaviour
{
    public List<Sentence> sentences;
   /* public int finalScoreRecipe;
    public int finalScoreMachine;
    public Text ScoreRecipeTxt;
    public Text ScoreMachineTxt;
    public IngredientCheck[] ingCheck;*/


    [Serializable]
    public class Sentence
    {
        [TextArea(5, 10)]
        public string sentence;
        public List<string> answers;
        public int correctAnswer;
        public int value;
    }

    /* private void Start()
     {

     }*/

    /*private void Update()
    {
        ScoreRecipeTxt.text = "Score recipe: " + finalScoreRecipe;
        finalScoreRecipe = sentences[0].value + sentences[1].value + sentences[2].value;
        ScoreMachineTxt.text = "Score machine: " + finalScoreMachine;
        finalScoreMachine = ingCheck[0].tubeValue + ingCheck[1].tubeValue + ingCheck[2].tubeValue;
    }*/
}
