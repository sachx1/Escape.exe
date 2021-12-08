using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skyboxTrigger : MonoBehaviour
{
    public Material skyOne;
    public Material skyTwo;
    public Material skyThree;
    // Start is called before the first frame update
    void Start()
    {
         
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "ball")
        {
            RenderSettings.skybox = skyOne;
            Debug.Log("skyOne");
        }
    }
}
