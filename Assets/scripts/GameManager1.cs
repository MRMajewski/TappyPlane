using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager1 : MonoBehaviour {

    public GameObject Terrain1;

    public GameObject Terrain2;
    // public GameObject plane;

    private GameObject hehe;
    private GameObject hoho;

    private float distance;


   
  /*  public int NumberOfBlocksPassed 
    {
        get { return numberOfBlocksPassed; }
        set { numberOfBlocksPassed = value; }
    } */


    // Use this for initialization
    void Awake () {
        var plane = FindObjectOfType<RandomPlane>();
        hehe = Instantiate(Terrain1, plane.transform.position + Vector3.right * 3.65f, Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
        var blocksPassed = FindObjectOfType<TerrainGenerator>().NumberOfBlocksPassed;
        var plane = FindObjectOfType<RandomPlane>();

        distance = Vector2.Distance(transform.position, plane.transform.position);

        if (distance/7.35 >= 2)
        {
            Destroy(hehe);
            
             hoho= Instantiate(Terrain2, plane.transform.position + Vector3.right *3.65f, Quaternion.identity);
        }

        if (distance / 7.35 >= 5)
        {
            Destroy(hoho);

            hehe = Instantiate(Terrain1, plane.transform.position + Vector3.right * 3.65f, Quaternion.identity);
        }

        if (distance / 7.35 >= 10)
        {
            Destroy(hehe);

            hoho = Instantiate(Terrain2, plane.transform.position + Vector3.right * 3.65f, Quaternion.identity);
        }


        Debug.Log("Odległość: " + distance);

    }

}
