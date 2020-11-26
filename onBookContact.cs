using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onBookContact : MonoBehaviour
{

    public GameObject feedback;
    bool isOn = false; 
    // Start is called before the first frame update
    void Start()
    {
        feedback = GameObject.Find("FeedbackUI");
    }

    // Update is called once per frame
    void Update()
    {
        if (isOn == false)
        {
            feedback.SetActive(false);
        }
        if(isOn == true)
        {
            feedback.SetActive(true);
        }
    }
    void OnTriggerEnter(Collider collision)
    {
            if (collision.gameObject.CompareTag("Hand"))
            {
                isOn = true;
            }
    }
}
