using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuitarPick : MonoBehaviour {


 private void OnTriggerEnter2D(Collider2D collider)
    {
        GetComponent<AudioSource>().Play();
        GetComponent<SpriteRenderer>().enabled = false;

        FindObjectOfType<PointsCounter>().IncrementPoints();

        Destroy(gameObject, 3f);
    }

}
