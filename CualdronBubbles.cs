using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CualdronBubbles : MonoBehaviour
{
    public GameObject AudioManager;
    public GameObject surfaceHB;
    public GameObject spoonHB;
    private Rigidbody bubbleRb;
    private Vector3 bubblePosition;
    [SerializeField] private float bubbleUpSp;
    [SerializeField] private float bubbleDownSp;
    [SerializeField] private float goingDownTime;
    [SerializeField] private bool bubbleRising;



    void Start()
    {
        //setting the default
        bubbleDownSp = 0.2f;
        bubbleUpSp = 0.3f;
        goingDownTime = 1f;
        bubbleRising = true;

        surfaceHB = GameObject.Find("SurfaceHB_BubParent");
        spoonHB = GameObject.Find("SpoonHB");
        bubbleRb = gameObject.GetComponent<Rigidbody>();
        AudioManager = GameObject.Find("AudioManager");

    }

    void FixedUpdate()
    {
        if (bubbleRising == true)
        {
            bubbleRb.AddForce(new Vector3(0f,bubbleUpSp,0f));
        }
        else { bubbleRb.AddForce(new Vector3(0f, -bubbleDownSp, 0f)); }

    }

    private void bubbleRiseSwitch()
    {
        Debug.Log("Switch");
        bubbleRising = true;
    }

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject == surfaceHB)
        {
            bubbleRb.velocity = Vector3.zero; //Get Rigidbody and set velocity to (0f, 0f, 0f)
            bubbleRising = false;
            Invoke("bubbleRiseSwitch", goingDownTime);
            
        }

        if (collision.gameObject == spoonHB)
        {
            if (this.gameObject.name == "BubbleToStir")
            {
                AudioManager.GetComponent<AudioManager>().PlayBubblePopSound(0);
            }
            if (this.gameObject.name == "BubbleToStir (1)")
            {
                AudioManager.GetComponent<AudioManager>().PlayBubblePopSound(1);
            }
            if (this.gameObject.name == "BubbleToStir (2)")
            {
                AudioManager.GetComponent<AudioManager>().PlayBubblePopSound(2);
            }
            if (this.gameObject.name == "BubbleToStir (3)")
            {
                AudioManager.GetComponent<AudioManager>().PlayBubblePopSound(3);
            }
            if (this.gameObject.name == "BubbleToStir (4)")
            {
                AudioManager.GetComponent<AudioManager>().PlayBubblePopSound(4);
            }
            if (this.gameObject.name == "BubbleToStir (5)")
            {
                AudioManager.GetComponent<AudioManager>().PlayBubblePopSound(5);
            }
            if (this.gameObject.name == "BubbleToStir (6)")
            {
                AudioManager.GetComponent<AudioManager>().PlayBubblePopSound(6);
            }
            if (this.gameObject.name == "BubbleToStir (7)")
            {
                AudioManager.GetComponent<AudioManager>().PlayBubblePopSound(7);
            }

            Destroy(gameObject, 0.25f);
        }
    }
}
