using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiManager : MonoBehaviour
{
    public GameObject InstructionsUi;
    public GameObject GameUi;

    public void CloseInstructionsUi()
    {
        Time.timeScale = 1;
        InstructionsUi.SetActive(false);
        GameUi.SetActive(true);
    }


    public void OpenInstructionsUi()
    {
        Time.timeScale = 0;
        InstructionsUi.SetActive(true);
    }
}
