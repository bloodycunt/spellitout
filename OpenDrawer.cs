using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDrawer : MonoBehaviour
{
    public GameObject drawer;


    private void OnTriggerEnter(Collider x)
    {
       if (x.gameObject.CompareTag("Hand"))
        {
            Debug.Log("yay");
           // drawer.transform.position = new Vector3(0, 0, Space.Self);


        }
    }

}
