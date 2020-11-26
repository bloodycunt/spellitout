using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeManager : MonoBehaviour
{
    public int totalLidsClosed;
   // public bool lidsOpen;

    // Start is called before the first frame update
    void Start()
    {
        // lidsOpen = false;
        transform.GetChild(0).gameObject.GetComponent<Collider>().enabled = false;
        transform.GetChild(1).gameObject.GetComponent<Collider>().enabled = false;
        transform.GetChild(2).gameObject.GetComponent<Collider>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        totalLidsClosed = transform.GetChild(0).gameObject.GetComponent<IngredientCheck>().ingredientsDroppped + transform.GetChild(1).gameObject.GetComponent<IngredientCheck>().ingredientsDroppped + transform.GetChild(2).gameObject.GetComponent<IngredientCheck>().ingredientsDroppped;
    }

    public void OpenLids()
    {
        Debug.Log("Lids opened");
        
        {
            transform.GetChild(0).gameObject.GetComponent<Collider>().enabled = true;
            transform.GetChild(1).gameObject.GetComponent<Collider>().enabled = true;
            transform.GetChild(2).gameObject.GetComponent<Collider>().enabled = true;
        }
       
    }
}
