using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyScroll : MonoBehaviour
{
    public List<GameObject> ScrollObj;

    // material shit
        public GameObject AudioManager;
        public int Ingredients = 9;
        public int RandomNum1;
        public int RandomNum2;
        public int RandomNum3;
        public Renderer MatChangeScreen1;
        public Renderer MatChangeScreen2;
        public Renderer MatChangeScreen3;
        public Material[] materials;
        public bool ScrollChecked;
        public GameObject TubesMan;
        public float sendAway;

    public void Start()
    {
        ScrollChecked = false;
        TubesMan = GameObject.Find("Tubes");
        sendAway = -60f;
        AudioManager = GameObject.Find("AudioManager");
    }

    //Collision with the scroll
    void OnTriggerEnter(Collider col)
     {
        if (ScrollChecked)
        {

        }
           //TubesMan.GetComponent<TubeManager>().OpenLids();

            for (int obj = 0; obj < ScrollObj.Count; obj++)
            {

                if (col.gameObject == ScrollObj[obj])
                {
                    AudioManager.GetComponent<AudioManager>().PlayLetterBoxSound();
                    AudioManager.GetComponent<AudioManager>().PlayScreenSound();
                    Debug.Log("scroll collides with machine reciever");
                    //ScrollObj[0].GetComponent<Collider>().enabled = false;
                    ScrollObj[0].GetComponent<MeshRenderer>().enabled = false;
                    ScrollObj[0].transform.position += new Vector3(0f, sendAway, 0f);
                    TubesMan.GetComponent<TubeManager>().OpenLids();


                    //randomize
                    for (int x = 0; x <= Ingredients; x++)
                    {
                        RandomNum1 = Mathf.RoundToInt(Random.Range(1f, 9f));
                        RandomNum2 = Mathf.RoundToInt(Random.Range(1f, 9f));
                        RandomNum3 = Mathf.RoundToInt(Random.Range(1f, 9f));

                        if (RandomNum1 != RandomNum2 && RandomNum1 != RandomNum3 && RandomNum2 != RandomNum3)
                        {
                            MatChangeScreen1.sharedMaterial = materials[RandomNum1 - 1];
                            MatChangeScreen2.sharedMaterial = materials[RandomNum2 - 1];
                            MatChangeScreen3.sharedMaterial = materials[RandomNum3 - 1];


                        }

                    }
                }
            }
    }
     
}




