using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IngredientCheck : MonoBehaviour
{
    public GameObject AudioManager;

    public Renderer Screen;
    public int tubeValue;
    public int ingredientsDroppped;


    private void Start()
    {
        AudioManager = GameObject.Find("AudioManager");

        ingredientsDroppped = 0;
    }

    void OnTriggerEnter(Collider col)
    {

        if (col.gameObject.CompareTag(Screen.sharedMaterial.name))
        {

            // Destroy
            Debug.Log(col.gameObject.name);
            Destroy(col.gameObject);
            tubeValue = 1;
            ingredientsDroppped += 1;
            this.gameObject.GetComponent<Collider>().enabled = false;
            AudioManager.GetComponent<AudioManager>().PlayLidCloseSound();

        }
        else if (col.gameObject.transform.parent.tag == "Ingredients")
        {
            Destroy(col.gameObject);
            Debug.Log(col.gameObject.name);
            Debug.Log("wrong");
            ingredientsDroppped += 1;
            this.gameObject.GetComponent<Collider>().enabled = false;
            AudioManager.GetComponent<AudioManager>().PlayLidCloseSound();

        }
    }

}
