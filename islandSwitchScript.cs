using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class islandSwitchScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "island")
        {
            SceneManager.LoadScene(1);
            Debug.Log("island");
        }
            
    }
}
