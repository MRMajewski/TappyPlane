using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class TerrainGenerator : MonoBehaviour {

    public GameObject[] TerrainBlocks;
    public GameObject InitialBlock;

    private List<GameObject> CurrentBlocks = new List<GameObject>();
    private int BlockIndex = 0;


    public float blockWidth = 7.4f;
	// Use this for initialization
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
        GetComponent<BoxCollider2D>().transform.position = Vector2.right * (BlockIndex-2) * blockWidth;

        BlockIndex++;
    }

    private void OnTriggerEnter2D (Collider2D collider)
    {
        GenerateBlock();

        var block = CurrentBlocks.First();
        Destroy(block);
        CurrentBlocks.RemoveAt(0);
    }

}

