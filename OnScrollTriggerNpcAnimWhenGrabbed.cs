using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnScrollTriggerNpcAnimWhenGrabbed : MonoBehaviour
{
    public GameObject AudioManager;
    public GameObject hand;
    public GameObject NPC;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        AudioManager = GameObject.Find("AudioManager");
    }

    // Update is called once per frame
    void Update()
    {
        hand = GameObject.Find("Collision Boye");
        NPC = GameObject.Find("NPC scroll");
        if (NPC != null)
        {
            anim = NPC.GetComponent<Animator>();
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        /*if (collision.gameObject == hand)
        {
         
            anim.Play("idle");
            gameObject.transform.parent = null;
            gameObject.GetComponent<Rigidbody>().useGravity = true;


        }*/

        if (collision.gameObject.tag == "Hand")
        {
            Invoke("PlayNPCIdle", 5f);
           // PlayNPCIdle();
            gameObject.transform.parent = null;
            gameObject.GetComponent<Rigidbody>().useGravity = true;
            GetComponent<Collider>().isTrigger = false;
            AudioManager.GetComponent<AudioManager>().PlayScrollSound();
        }
    }

    void PlayNPCIdle()
    {
        anim.Play("idle");
    }
}

