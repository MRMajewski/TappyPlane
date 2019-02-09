using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashMovement : MonoBehaviour {

    public Vector3 DashVector;
    private float dashTime;
    public float startDashTime;

    public GameManager GameManager;

    public GameObject dashEffect;

    private bool _isDashing;
    private float _lerpTime = 0.5f;

	void Start () {

        dashTime = startDashTime;
	}


    public void Dash()
    {
        if (!_isDashing)
        {
            _isDashing = true;
            StartCoroutine(Dashing());
            Debug.Log("Dash");
        }
      
    }

    private IEnumerator Dashing()
    {
        Particle();
        transform.position += DashVector;
        GameManager.CameraMovement.StopCamera();
        GameManager.CameraMovement.StartLerpingToTrackedObject(_lerpTime, transform.position);
        GameManager.MonkMovement.SetFlyingState(false);
        yield return new WaitForSeconds(_lerpTime);
        GameManager.MonkMovement.SetFlyingState(true);
        GameManager.CameraMovement.ResumeCamera();
        _isDashing = false;
      
    }

    public void Particle()
    { 
        Instantiate(dashEffect, transform.position + Vector3.right * 0.2f, Quaternion.Euler(0, 0, 0));
    }
}
