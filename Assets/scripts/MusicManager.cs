using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour {

	// Use this for initialization
	void Start () {

        if (FindObjectsOfType<MusicManager>().Length > 1) Destroy(gameObject);
        DontDestroyOnLoad(gameObject);
	}

}
