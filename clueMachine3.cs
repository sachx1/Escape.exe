using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clueMachine3 : MonoBehaviour
{
    // Start is called before the first frame update
    // private clueMachine2 clue2;

    clueMachine clueMachineScript;
    clueMachine2 clueMachine2Script;
    private clueMachine clue1;
    bool keyClue2;
    bool keyClue1;
    public bool keyCount3 = false;
    //clueMachine2 intake = GameObject.GetComponent<clueMachine2>().keyCount2;
    clueMachine cluef1 = new clueMachine();
    clueMachine2 cluef2 = new clueMachine2();
    
    void Start()
    {
        //keyclue2 = clue2.keyCount2;
        //Debug.Log("clue2 value is :" + keyclue2);
        //keyclue1 = cluef1.keyCount1;
        //keyclue2 = cluef2.keyCount2;
        keyClue1 = false;
        keyClue1 = clueMachineScript.keyCount1;

        keyClue2 = false;
        keyClue2 = clueMachine2Script.keyCount2;
        
    }

    // Update is called once per frame
    void Update()
    {
        check();
    }

    private void OnTriggerEnter(Collider collider)
    {


        //check();
        if (collider.gameObject.tag == "floppy3")
        {
            keyCount3 = true;
            Debug.Log("its working");
            //keyCount2 = true;

            //Debug.Log("Teleport");
            //player = collider.transform.gameObject;
            //player.transform.position = spawnPoint.transform.position;
        }

        
    }

    void check()
    {
        //if (keyClue1 == true && keyClue2 == true && keyCount3 == true)
        //{
        //    Debug.Log("hi hello");
        //}

        if (keyClue1 == true)
        {
            Debug.Log("confirmation");
        }
    }


}
