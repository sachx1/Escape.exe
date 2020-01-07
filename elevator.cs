using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Linq;
using System;

public class elevator : MonoBehaviour
{
    //private KeywordRecognizer keywordRecognizer;
    //private Dictionary<string, Action> actions = new Dictionary<string, Action>();
    public GameObject key1;
    public GameObject key2;
    public GameObject Prefab;
    public Vector3 startPosition;
    public Vector3 endPosition;
    private AnimationClip anim;
    public bool keyCount1 = false;
    public bool keyCount2 = false;
    public bool keyCount3 = false;
    public GameObject elevator1;
    public float speed = 2f;
    public Transform Spawnpoint;

    void Start()
    {
        //actions.Add("call", Up);


        //keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        //keywordRecognizer.OnPhraseRecognized += RecgonizedSpeech;
        //keywordRecognizer.Start();
        //check();
    }

    void Update()
    {
        //check();
    }


    private void Up()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        //check();
        if (collider.gameObject.tag == "key1")
        {
            keyCount1 = true;
            //keyCount2 = true;
           
            //Debug.Log("Teleport");
            //player = collider.transform.gameObject;
            //player.transform.position = spawnPoint.transform.position;
        } 

        if (collider.gameObject.tag == "key2")
        {
            keyCount2 = true;
        }

        if (collider.gameObject.tag == "key3")
        {
            keyCount3 = true;
        }

        if (keyCount1 == true && keyCount2 == true && keyCount3 == true)
        {
            //Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
            elevator1.SetActive(true);
        }
        

        

       
    }

    private void check()
    {
        

        if (keyCount1 == true)
        {
            
            Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
        }
    }




}


