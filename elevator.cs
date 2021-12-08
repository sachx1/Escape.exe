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
    public GameObject key3;
    public GameObject floppy;
    public GameObject word;
    public bool keyCount1 = false;
    public bool keyCount2 = false;
    public bool keyCount3 = false;
    public Transform Spawnpoint;
    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();

    void Start()
    {
        //actions.Add("call", Up);

        //check();
        //keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        //keywordRecognizer.OnPhraseRecognized += RecgonizedSpeech;
        //keywordRecognizer.Start();
        //check();
        actions.Add("keybox", appear);
        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += RecgonizedSpeech;
        keywordRecognizer.Start();
        word.SetActive(false);

    }

    void Update()
    {
        check();   
    }

    private void Up()
    {
        
    }

    private void RecgonizedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text);
        actions[speech.text].Invoke();
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
       
    }

    void appear()
    {
        Instantiate(floppy, Spawnpoint.position, Spawnpoint.rotation);
    }

    void check()
    {
        

        if (keyCount1 == true && keyCount2 == true && keyCount3 == true)
        {
            word.SetActive(true);
            //Instantiate(floppy, Spawnpoint.position, Spawnpoint.rotation);
        }
    }




}


