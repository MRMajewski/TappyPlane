using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneWhenClicked : MonoBehaviour {

    public string levelName = "level1";

void OnMouseDown()
    {
        SceneManager.LoadScene(levelName);
    }
}
