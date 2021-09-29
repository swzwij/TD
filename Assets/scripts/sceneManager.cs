using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
    public void start()
    {
        SceneManager.LoadScene("Play"); 
    }

    public void exitgame()
    {
        Application.Quit(); 
    }
}
