using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour {


   // [SerializeField]
  //  Transform respawnPlace;

    public GameObject[] TerrainBlocks;
    public GameObject InitialBlock;

    private List<GameObject> CurrentBlocks = new List<GameObject>();
    private int BlockIndex = 0;

    public float blockWidth = 7.4f;

    private void Awake()
    {
        //  respawnPlace = FindObjectOfType<TerrainGenerator>().transform;
     //   respawnPlace = FindObjectOfType<GameManager>().transform;
    }


    void Start () {

 
		
        for (int i=0; i<4;i++)
        {
            GenerateBlock();
        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void GenerateBlock()
    {
        var index = Random.Range(0, TerrainBlocks.Length);
        var prefab = TerrainBlocks[index];


        if (BlockIndex < 2) prefab = InitialBlock;

        var block = Instantiate(prefab);
        CurrentBlocks.Add(block);

        block.transform.position = Vector2.right * BlockIndex * blockWidth;
        GetComponent<BoxCollider2D>().transform.position = Vector2.right * (BlockIndex - 2) * blockWidth;

        BlockIndex++;

        //  var block = Instantiate(prefab, Vector3.right * BlockIndex * blockWidth, Quaternion.identity);
        //var block = Instantiate(prefab, (respawnPlace.position + Vector3.right * blockWidth)+Vector3.right*(0.5f), Quaternion.identity);
       // CurrentBlocks.Add(block);

     //   block.transform.position = Vector3.right * BlockIndex * blockWidth;
      //  GetComponent<BoxCollider2D>().transform.position = respawnPlace.position+(Vector3.right *4f) + Vector3.right * (BlockIndex-2) * blockWidth;
     //   GetComponent<BoxCollider2D>().transform.position = respawnPlace.position + Vector3.right * (BlockIndex - 2)* blockWidth;

      //  BlockIndex++;
    }

    private void OnTriggerEnter2D (Collider2D collider)
    {

        GenerateBlock();

        var block = CurrentBlocks.First();
        Debug.Log("przed destroyem");
        Destroy(block);
        Debug.Log("Po destroyu");
        CurrentBlocks.RemoveAt(0);
           
    }

}

