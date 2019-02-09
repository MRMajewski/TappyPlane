using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{

    public static bool isPaused;

    [SerializeField]
    private Text ButtonText;

    private void Start()
    {
    //    Text ButtonText = GetComponentInChildren<Text>();
    }

    public void Action()
    {
        if (!isPaused) Pause();

        else Resume();
    }

    public void Pause()
    {
        Debug.Log("pauza");
        Time.timeScale = 0;
        isPaused = true;
        ButtonText.text = "Resume";   
    }

    public void Resume()
    {
        Time.timeScale = 1;
        isPaused = false;
         ButtonText.text = "Pause";
      
    }
}


