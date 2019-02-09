using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour {

    
    public MonkMovement PlaneMovement;

    [SerializeField]
    DashMovement DashMovement;

    public int BlocksPassed = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    private void OnTriggerEnter2D(Collider2D collider)
    {
        BlocksPassed++;
        //   Debug.Log("Minąłeś: "+BlocksPassed+" bloków");
    }
}
