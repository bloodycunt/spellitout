using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcController : MonoBehaviour
{
    public GameObject AudioManager;
    public GameObject smokePrefab;
    //This is the main script for controlling the NPC character and its animations
    //some gameobjects for ya
    public GameObject frontdesk;
    public GameObject bell;
    public GameObject hand;
    public GameObject vial;
    private Animator anim;
    private Collider m_Collider;
    int x = 0;
    public float speed = 1;

    public GameObject scroll;
    public Material[] transformations;

    public int EndScore;
    // Start is called before the first frame update
    void Start()
    {
        scroll = GameObject.Find("ScoreScriptForTransformations");

        //gets the collider component for the bell object and sets it to false, so that it doesn't trigger with the hand
        m_Collider = bell.GetComponent<Collider>();
        m_Collider.enabled = false;

        AudioManager = GameObject.Find("AudioManager");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SmokeAppear();
        }

        frontdesk = GameObject.Find("frontdesk");
        vial = GameObject.Find("Vial(Clone)");
        bell = GameObject.Find("Bell");
        hand = GameObject.Find("Collision Boye");
     

        anim = GetComponent<Animator>();
        if (x == 0)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        else
        {
            transform.Translate(Vector3.zero * Time.deltaTime);
        }
        Debug.Log(x);
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject == frontdesk)
        {
            
            x = 1;
            //here it stops the player from moving and sets the animation to the idle animation
            anim.Play("idle");
            Debug.Log("it's happening");
            //Enables the collider to the bell object
            Debug.Log("Collider.enabled = " + m_Collider.enabled);
            m_Collider.enabled = true;
        }
        if(collision.gameObject == vial)
        {

            CalculateScore();

            AudioManager.GetComponent<AudioManager>().Invoke("PlayGulpingSound", 2.5f);
            AudioManager.GetComponent<AudioManager>().Invoke("PlayBurpSound", 3.75f);

            //plays the drinking animation for the NPC
            anim.Play("drincc");
            //destroys the instance of the vial being spawned
            Destroy(vial);

        }
    }


    void CalculateScore()
    {
        if (scroll.GetComponent<canvasscript>().finalScoreMachine < scroll.GetComponent<canvasscript>().finalScoreRecipe)
        {
            EndScore = scroll.GetComponent<canvasscript>().finalScoreMachine;
        }
        else
        {
            EndScore = scroll.GetComponent<canvasscript>().finalScoreRecipe;
        }

        Invoke("SmokeAppear", 4.5f);
        Invoke("Transform", 5f);
    }

    public void SmokeAppear()
    {
        GameObject Smoke = Instantiate(smokePrefab, new Vector3(transform.position.x -0.75f, transform.position.y, transform.position.z), transform.rotation);
    }

    void Transform()
    {
        AudioManager.GetComponent<AudioManager>().Invoke("PlayFeedback",2f);
        if (EndScore == 0)
        {
            Debug.Log("EndScore =" + EndScore);
            transform.GetChild(0).GetComponent<Renderer>().material = transformations[0];
            AudioManager.GetComponent<AudioManager>().PlayReaction1();
        }
        else if (EndScore == 1)
        {
            Debug.Log("EndScore =" + EndScore);
            transform.GetChild(0).GetComponent<Renderer>().material = transformations[1];
            AudioManager.GetComponent<AudioManager>().PlayReaction1();
        }
        else if (EndScore == 2)
        {
            Debug.Log("EndScore =" + EndScore);
            transform.GetChild(0).GetComponent<Renderer>().material = transformations[2];
            AudioManager.GetComponent<AudioManager>().PlayReaction2();
        }
        else if (EndScore == 3)
        {
            Debug.Log("EndScore =" + EndScore);
            transform.GetChild(0).GetComponent<Renderer>().material = transformations[3];
            AudioManager.GetComponent<AudioManager>().PlayReaction3();
        }



    }
}
