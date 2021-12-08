using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clueMachine2 : MonoBehaviour
{
    // Start is called before the first frame update
    public bool keyCount2 = false;

    public clueMachine2()
    {

    }

    private void OnTriggerEnter(Collider collider)
    {
        //check();
        if (collider.gameObject.tag == "floppy2")
        {
            keyCount2 = true;
            Debug.Log("floppy 2");
            //keyCount2 = true;

            //Debug.Log("Teleport");
            //player = collider.transform.gameObject;
            //player.transform.position = spawnPoint.transform.position;
        }   

       
    }
}
