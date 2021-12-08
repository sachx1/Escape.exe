using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;
using System.Linq;
using System;

public class puzzle3 : MonoBehaviour
{
    public Transform Spawnpoint;
    public GameObject Prefab;
    private KeywordRecognizer keywordRecognizer;
    private Dictionary<string, Action> actions = new Dictionary<string, Action>();
    public AudioClip soundToPlay;
    AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        actions.Add("fire", Fire);
        actions.Add("feyer", Fire);
        actions.Add("fyah", Fire);
        actions.Add("fyre", Fire);
        actions.Add("fyare", Fire);
        actions.Add("fiur", Fire);
        keywordRecognizer = new KeywordRecognizer(actions.Keys.ToArray());
        keywordRecognizer.OnPhraseRecognized += RecgonizedSpeech;
        keywordRecognizer.Start();
        audio = GetComponent<AudioSource>();

    }

    private void RecgonizedSpeech(PhraseRecognizedEventArgs speech)
    {
        Debug.Log(speech.text);
        actions[speech.text].Invoke();
    }

    private void Fire()
    {
        Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
        audio.PlayOneShot(soundToPlay);
    }
}
