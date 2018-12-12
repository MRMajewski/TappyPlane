using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject[] TerrainGenerators;

    public GameObject FirstGenerator;
    private GameObject ActualTerrainGenerator;
    private GameObject generator;
    private int index;

    [SerializeField]
    GameObject plane;

    private float distance;


    // Use this for initialization
    void Awake () {
         index = UnityEngine.Random.Range(0, TerrainGenerators.Length);
         generator = TerrainGenerators[index];

       
        ActualTerrainGenerator = Instantiate(generator, plane.transform.position + Vector3.right * 11.025f, Quaternion.identity);
    }
	
	// Update is called once per frame
	void Update () {
        

        distance = Vector2.Distance(transform.position, plane.transform.position);
     
        if (Math.Abs(distance - 5) < 0.1)
            {
            Debug.Log("UWAGA");

            Destroy(ActualTerrainGenerator);

            index = UnityEngine.Random.Range(0, TerrainGenerators.Length);
             generator = TerrainGenerators[index];

                ActualTerrainGenerator = Instantiate(generator, plane.transform.position + Vector3.right * 11.025f, Quaternion.identity);
            }
        Debug.Log("Odległość: " + distance);



        /*    if (distance / 7.35 == 15)
            {
                var index = Random.Range(0, TerrainGenerators.Length);
                var generator = TerrainGenerators[index];

                Destroy(ActualTerrainGenerator);

                ActualTerrainGenerator = Instantiate(generator, plane.transform.position + Vector3.right * 3.65f, Quaternion.identity);
            }

        */



    }

}
