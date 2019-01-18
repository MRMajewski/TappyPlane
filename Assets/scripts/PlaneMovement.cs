using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaneMovement : MonoBehaviour {

    public float FlyingAngle = 60f;
    public float FallingAngle = -80f;

    public float CurrentAngle = 0f;

    public int BlocksPassed=0;


    public float Speed = 2f;
    void Update() {

        var targetAngle = Input.GetMouseButton(0)
            ? FlyingAngle : FallingAngle;
        CurrentAngle = Mathf.Lerp(CurrentAngle, targetAngle, Time.deltaTime*2f);

        transform.rotation = Quaternion.Euler(Vector3.forward * CurrentAngle);
        transform.Translate(Vector3.right * Speed*Time.deltaTime);

        if(Mathf.Abs(transform.position.y) > 2f)
        {
            SceneManager.LoadScene("gameover");
        }
	}

    private void OnTriggerEnter2D(Collider2D collider)
    {
     //   BlocksPassed++;
     //   Debug.Log("Minąłeś: "+BlocksPassed+" bloków");
    }

}
 