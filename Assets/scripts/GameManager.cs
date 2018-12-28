using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

   // public TerrainGenerator[] TerrainGenerators;

    [SerializeField]
    Transform respawnPlace;
    
    private TerrainGenerator ActualTerrainGenerator;

        [SerializeField]
    TerrainGenerator generator;

    [SerializeField]
    TerrainGenerator FirstGenerator;

    private int index;
    int blockPassed;

    [SerializeField]
    Plane plane;


    void Awake()
    {
        //      index = UnityEngine.Random.Range(0, TerrainGenerators.Length);
        //generator = TerrainGenerators[index];
       
        ActualTerrainGenerator = Instantiate(FirstGenerator, respawnPlace.position, Quaternion.identity);
        //Instantiate(plane, respawnPlace.position, Quaternion.identity);


        // ActualTerrainGenerator.transform.localPosition = respawnPlace.position; 
        //  ActualTerrainGenerator = Instantiate(generator, plane.transform.position , Quaternion.identity);
        // Vector3.right * 11.025f
        blockPassed = plane.BlocksPassed;
    }


    // Update is called once per frame
    void Update()
    {
        Debug.Log("pozycja GENERATORA:" + ActualTerrainGenerator.transform.position);
        blockPassed = plane.BlocksPassed;       
        Debug.Log("Minąłeś: " + blockPassed + " bloków");
     //   Debug.Log("Minąłeś: " + respawnPlace.position);

        if (blockPassed == 5)
        {
            plane.BlocksPassed = 0;
            Debug.Log("UWAGA");

         //   Destroy(plane.gameObject);
            Destroy(ActualTerrainGenerator.gameObject);
            Debug.Log("DESTROY");
            //        index = UnityEngine.Random.Range(0, TerrainGenerators.Length);

            Debug.Log("Minąłeś: " + blockPassed + " bloków");
            //    Instantiate(plane, PlanePosition + Vector3.right*2f, Quaternion.identity);
            ActualTerrainGenerator = Instantiate(generator, respawnPlace.position + Vector3.right * 10f,Quaternion.identity);
            Debug.Log("pozycja GENERATORA:" + ActualTerrainGenerator.transform.position);
          

            ActualTerrainGenerator.transform.position = respawnPlace.position + Vector3.right * 20f;
            // ActualTerrainGenerator.transform.localPosition = PlanePosition + Vector3.right * 600.35f;
            Debug.Log("pozycja GENERATORA:" + ActualTerrainGenerator.transform.position);
        }
    }
}
