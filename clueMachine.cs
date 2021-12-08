using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using UnityEngine.Video;

public class clueMachine : MonoBehaviour
{

    //public RawImage image;
    // Start is called before the first frame update
    public bool keyCount1 = false;
    public bool keyCount = false;
    public Transform Spawnpoint;
    public GameObject Prefab;
    
    public VideoClip book;
    public VideoClip glass;
    public VideoClip voice;

    private VideoPlayer videoPlayer;
    private VideoSource videoSoure;
    
    public Texture[] textures;
    public int currentTexture;

    public bool keyCount2 = false;
    public bool keyCount3 = false;

    public GameObject ElevatorDoorLeft;
    public GameObject ElevatorDoorRight;
    public GameObject ElevatorAnim;
    public float speed;

    public GameObject Clue;
    public GameObject ClueBook;
    public GameObject ClueGlass;
    public GameObject ClueVoice;

    Renderer ClueScreen;
    Renderer Book;
    Renderer Glass;
    Renderer Voice;



    //public AudioClip triggerSound;
    public AudioClip soundToPlay;
    AudioSource audio;
    


    /*
     * 
     * http://justcode.me/unity2d/how-to-play-videos-on-unity-using-new-videoplayer/
     * 
     */

    void Start()
    {
        //Prefab.SetActive(false);
        //audioSource = GetComponent<AudioSource>();
        audio = GetComponent<AudioSource>();

        ClueScreen = Clue.GetComponent<Renderer>();
        ClueScreen.enabled = true;

        Book = ClueBook.GetComponent<Renderer>();
        Book.enabled = false;

        Glass = ClueGlass.GetComponent<Renderer>();
        Glass.enabled = false;

        Voice = ClueVoice.GetComponent<Renderer>();
        Voice.enabled = false;


    }

// Update is called once per frame
void Update()
{
    Elevator();

    
}

void OnTriggerEnter(Collider collider)
{


    if (collider.gameObject.tag == "floppy1")
        {
            Debug.Log("Floppy1");
            //keyCount1 = true;
            ClueScreen.enabled = false;
            Book.enabled = true;
            Glass.enabled = false;
            Voice.enabled = false;
            currentTexture++;
            currentTexture %= textures.Length;
            GetComponent<Renderer>().material.mainTexture = textures[currentTexture];
            keyCount = true;
            audio.PlayOneShot(soundToPlay);
        }
        
    if (collider.gameObject.tag == "floppy2")
    {
        Debug.Log("Floppy2");
            ClueScreen.enabled = false;
            Book.enabled = false;
            Glass.enabled = true;
            Voice.enabled = false;
            keyCount2 = true;
            audio.PlayOneShot(soundToPlay);
        }

    if (collider.gameObject.tag == "floppy3")
        {
            Debug.Log("Floppy3");
            ClueScreen.enabled = false;
            Book.enabled = false;
            Glass.enabled = false;
            Voice.enabled = true;
            keyCount3 = true;
            audio.PlayOneShot(soundToPlay);
        }
        //check();
        
    //check();
    

}

void Elevator()
{
    if (keyCount == true && keyCount2 == true && keyCount3 == true)
    {
        Prefab.SetActive(true);
        ElevatorDoorLeft.GetComponent<Animator>().Play("elevatorDoorLeft");
        ElevatorDoorRight.GetComponent<Animator>().Play("elevatorDoorRight");
        ElevatorAnim.GetComponent<Animator>().Play("elevatorMove");
        //GetComponent<Animator>().Play("elevatorDoorLeft");
            //float step = speed * Time.deltaTime;
            
            //transform.position = Vector3.MoveTowards(transform.position, target.position, step);
            //float move = speed * Time.deltaTime;
            //transform.position = Vector3.MoveTowards(transform.position, target.position, move);
    }
}

   

}
