using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnBellHandCollisionCheck : MonoBehaviour
{
    public GameObject AudioManager;
    public GameObject collideBoye;
    public GameObject NPC;
    private Animator anim;
    int x = 0;

    // Start is called before the first frame update
    void Start()
    {
        AudioManager = GameObject.Find("AudioManager");
    }
    private void Update()
    {
        
            NPC = GameObject.Find("NPC scroll");


        if (NPC != null)
        {
            anim = NPC.GetComponent<Animator>();
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (x == 0)
        {
            
              if (collision.gameObject == collideBoye)
            {
                Debug.Log("peen");
                anim.Play("give recipe");
                x = 1;


            }
            

            if(collision.gameObject.tag == "Hand")
            {
                Debug.Log("peen");
                anim.Play("give recipe");
                x = 1;
                AudioManager.GetComponent<AudioManager>().PlayBellSound();
            }
        }
    }
    
}
