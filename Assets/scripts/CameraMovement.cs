using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {



    public Transform TrackedObject;

    public float DeltaX;
	

	void Update () {

        transform.position = new Vector3
            (TrackedObject.position.x + DeltaX, transform.position.y, transform.position.z);
            
		
	}
}
