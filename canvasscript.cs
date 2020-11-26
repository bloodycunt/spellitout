using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvasscript : MonoBehaviour
{
    public Recipe recipe;
    public int finalScoreRecipe;
    public int finalScoreMachine;
    public Text ScoreRecipeTxt;
    public Text ScoreMachineTxt;
    public IngredientCheck[] ingCheck;


    public void Update()
{
    ScoreRecipeTxt.text = "Score recipe: " + finalScoreRecipe;
    finalScoreRecipe = recipe.sentences[0].value + recipe.sentences[1].value + recipe.sentences[2].value;
    ScoreMachineTxt.text = "Score machine: " + finalScoreMachine;
    finalScoreMachine = ingCheck[0].tubeValue + ingCheck[1].tubeValue + ingCheck[2].tubeValue;
}
}