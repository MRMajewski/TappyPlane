using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public GameObject UiInstructions;
    public GameObject UiMenu;
    
    public Sprite InstructionsBackground;

    public Image BackgroundImage;


    public string LevelName = "level1";

    public void OpenInstructions()
    {
        SwitchPanels();
    }

    private void SwitchBackground()
    {
        BackgroundImage.sprite = InstructionsBackground;
    }

    private void SwitchPanels()
    {
        UiMenu.SetActive(false);
        UiInstructions.SetActive(true);
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(LevelName);
    }
    
    public void Quit()
    {
        Debug.Log("quit");
        Application.Quit();
    }
}
