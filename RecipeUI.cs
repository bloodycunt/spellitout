using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecipeUI : MonoBehaviour
{
    public List<Text> sentences;
    public List<Text> answers;
    public List<Button> buttons;
    public Recipe recipe;

    public void Start()
    {
        for (int i = 0; i < buttons.Count; ++i)
        {
            Button button = buttons[i];

            // needed for fixing a stupid problem
            int j=i;

            button.onClick.AddListener(() => PressButton(j));
        }
    }
 

    //when you press the button
    public void PressButton(int y)
    {
        Debug.Log(y);

        // dividing the buttons into 3 sentances
        int sentence = y / 3;

        //whats left after the divide
        int answer = y % 3;

        Debug.Log(sentence);
        Debug.Log(answer);

        //change the value based on which sentence is clicked
        recipe.sentences[sentence].value = answer == recipe.sentences[sentence].correctAnswer ? 1 : 0;
    }

    //set the text
    public void SetRecipe(Recipe recipe)
    {
        this.recipe = recipe;
        for (int i = 0; i < sentences.Count; ++i)
        {
            sentences[0].text = recipe.sentences[0].sentence;
            sentences[1].text = recipe.sentences[1].sentence;
            sentences[2].text = recipe.sentences[2].sentence;

            for (int x = 0; x < answers.Count; ++x)
            {
                answers[0].text = recipe.sentences[0].answers[0];
                answers[1].text = recipe.sentences[0].answers[1];
                answers[2].text = recipe.sentences[0].answers[2];
                answers[3].text = recipe.sentences[1].answers[0];
                answers[4].text = recipe.sentences[1].answers[1];
                answers[5].text = recipe.sentences[1].answers[2];
                answers[6].text = recipe.sentences[2].answers[0];
                answers[7].text = recipe.sentences[2].answers[1];
                answers[8].text = recipe.sentences[2].answers[2];

            }
        }
    }
}
