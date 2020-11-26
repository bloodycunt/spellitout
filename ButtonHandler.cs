/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonHandler:MonoBehaviour
{
    public bool isCorrect;
    public int value;
    public Recipe recipe;
    public bool clicked;

    public void Start()
    {
        var button = GetComponent<Button>();
        button.onClick.AddListener(Check);
    }

    public void Check() {

        Debug.Log("check");

        if (isCorrect & !clicked)
        {
            clicked = true;
            recipe.score ++;
        }
    }

    void Check()
    {
        if (isCorrect == true)
        {
            value = 1;
        }
        else
        {
            value = 0;
        }
    }

}*/

