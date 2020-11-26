using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StirManScript : MonoBehaviour
{
    public GameObject AudioManager;
    public GameObject surfaceHB_BubParent;
    public GameObject bubGroup;
    public GameObject bubGroupPrefab;
    public GameObject potionPrefab;
    public GameObject tubeMan;
    public bool alreadyNarrated;
    [SerializeField] private float stirsNeededFinish;
    [SerializeField] private float stirsNow;
    [SerializeField] private int amountOfBubbles;
    
    // Start is called before the first frame update
    void Start()
    {
        stirsNeededFinish = 2f;
        stirsNow = 0f;
        bubGroup = GameObject.Find("BubbleGroup");
        tubeMan = GameObject.Find("Tubes");
        AudioManager = GameObject.Find("AudioManager");
        alreadyNarrated = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (tubeMan.GetComponent<TubeManager>().totalLidsClosed >= 3)
        {
            if (alreadyNarrated == false)
            {
                AudioManager.GetComponent<AudioManager>().PlayStirInstruction();
                alreadyNarrated = true;
            }

            if (bubGroup == null)
            {
                if (stirsNow != stirsNeededFinish)
                {
                    bubGroup = Instantiate(bubGroupPrefab, transform.position, transform.rotation);
                    bubGroup.transform.parent = surfaceHB_BubParent.transform;
                    AudioManager.GetComponent<AudioManager>().IncreaseCualdronVolume();
                }

            }
            else
            {
                amountOfBubbles = surfaceHB_BubParent.transform.GetChild(0).childCount;

                Debug.Log(amountOfBubbles);
                if (amountOfBubbles == 0)
                {
                    Destroy(bubGroup);
                    stirsNow++;

                    if (stirsNow == stirsNeededFinish)
                    {
                        GameObject Potion = Instantiate(potionPrefab, new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z), transform.rotation);
                        AudioManager.GetComponent<AudioManager>().DecreaseCualdronVolume();
                        AudioManager.GetComponent<AudioManager>().PlayAfterDoneStirring();
                        AudioManager.GetComponent<AudioManager>().Invoke("PlayAfterDoneStirring2", 3f);


                    }
                }

            }
        }
    }
}
