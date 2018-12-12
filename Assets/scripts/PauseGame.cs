using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseGame : MonoBehaviour
{

    public static bool isPaused = false;

    [SerializeField]
    Text ButtonText;

    [SerializeField]
    Canvas canvas;



    void Start()
    {
        Text ButtonText = GetComponentInChildren<Text>();
       // canvas.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Action()
    {
        if (!isPaused)
            Pause();

        else Resume();
    }

    public void Pause()
    {
        Time.timeScale = 0;
        isPaused = true;
        ButtonText.text = "Resume";
       // canvas.enabled = true;
    }

    public void Resume()
    {
        Time.timeScale = 1;
        isPaused = false;
         ButtonText.text = "Pause";
       // canvas.enabled = false;
    }
}


