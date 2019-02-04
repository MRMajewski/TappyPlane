using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashMovement : MonoBehaviour {

    private Rigidbody2D rb;
    public float dashSpeed;
    private float dashTime;
    public float startDashTime;

    public GameObject dashEffect;
    
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        dashTime = startDashTime;
	}

    // Update is called once per frame
    /*	void Update () {

            if (Input.GetMouseButton(0)) ;
            {
                Dash();
            }

        } */

     




    public void Dash()
    {
      //  if (dashTime >= 0) dashTime -= Time.deltaTime;
      //  else dashTime -= Time.deltaTime;

       // rb.velocity = Vector2.right * dashTime;
       
        transform.Translate(Vector3.right * dashSpeed * Time.deltaTime);
        Particle();
      
    }

    public void Particle()
    {
        // Instantiate(dashEffect, transform.position + Vector3.right * 2.7f, Quaternion.Euler(0,-90,0));
        Instantiate(dashEffect, transform.position + Vector3.right * 0.2f, Quaternion.Euler(0, 0, 0));
    }
}
