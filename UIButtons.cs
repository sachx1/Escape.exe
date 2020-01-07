using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIButtons : MonoBehaviour
{

    public GameObject StartMenu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void exitOnPress()
    {
        Application.Quit();
    }

    public void playGame()
    {
        SceneManager.LoadScene("studio_Set");
    }
}
