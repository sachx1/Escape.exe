using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Linq;
using System;

public class lightSwitch : MonoBehaviour
{
    //public Transform Spawnpoint;
    public GameObject light;
    public GameObject light2;
    public GameObject smoke;
    //public GameObject text;
    //public AudioClip audioClip;
    //public AudioSource audioSource;
    private int isOn = 0;
    private bool on = false;
    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();
    // Start is called before the first frame update
    void Start()
    {
        //audioSource.clip = audioClip;
        actions.Add("power on", Light);
        actions.Add("How do I turn the power on", Light);
        //actions.Add("ma", Map);
        //actions.Add("mahp", Map);
        //actions.Add("mup", Map);
        //actions.Add("muhp", Map);
        //actions.Add("awn", Light);
        actions.Add("awe", Light);
        //actions.Add("one", Light);
        actions.Add("ohn", Light);
        actions.Add("ahn", Light);
        actions.Add("awen", Light);
        //actions.Add("power off", LightOff);
        light2.SetActive(false);
        light.SetActive(false);
        smoke.SetActive(false);
        //text.SetActive(true);
        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += RecgonizedSpeech;
        keywordRecognizer.Start();

    }

    private void RecgonizedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text);
        actions[speech.text].Invoke();
    }

    private void Light()
    {
        //Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
        light.SetActive(true);
        light2.SetActive(true);
        smoke.SetActive(true);
        //text.SetActive(false);
        //audioSource.Play();
        on = true;
    }

    private void LightOff()
    {
        light.SetActive(false);
        smoke.SetActive(false);
        //text.SetActive(true);
        //audioSource.Stop();
        on = false;

    }
}

