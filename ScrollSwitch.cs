using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollSwitch : MonoBehaviour
{
    public GameObject AudioManager;
    public GameObject UI;
    public RecipeUI setRecipe;
    public Recipe[] recipe;
    public GameObject[] scrolls;

    public GameObject MachineSlot;

    void Start()
    {
        AudioManager = GameObject.Find("AudioManager");
    }

    void OnTriggerEnter(Collider x)
    {
        
        if (x.gameObject == scrolls[0])
        {

            AudioManager.GetComponent<AudioManager>().PlayCheckBoxSound();

            UI.SetActive(true);
            Debug.Log("works");
            setRecipe.SetRecipe(recipe[0]);
            MachineSlot.GetComponent<DestroyScroll>().ScrollChecked = true;



        }
        else if (x.gameObject == scrolls[1])
        {

            UI.SetActive(true);
            Debug.Log("works");
            setRecipe.SetRecipe(recipe[1]);

        }
        else if (x.gameObject == scrolls[2])
        {

            UI.SetActive(true);
            Debug.Log("works");
            setRecipe.SetRecipe(recipe[2]);

        }
        Debug.Log(MachineSlot.GetComponent<DestroyScroll>().ScrollChecked);
    }

    void OnTriggerExit(Collider x)
    {
        if (x.gameObject.CompareTag("Scroll"))
        {
            AudioManager.GetComponent<AudioManager>().PlayCheckBoxSoundLeave();
            UI.SetActive(false);

        }
    }

}
