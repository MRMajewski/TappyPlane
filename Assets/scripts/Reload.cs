using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reload : MonoBehaviour {

	// Use this for initialization
	void Start () {

        StartCoroutine(reloadSceneCouritine());

    }

    IEnumerator reloadSceneCouritine()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("level1");

    }

    }
