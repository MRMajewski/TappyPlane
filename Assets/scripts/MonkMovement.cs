using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkMovement : MonoBehaviour {

    public float FlyingAngle = 60f;
    public float FallingAngle = -80f;

    public float CurrentAngle = 0f;

    public bool IsMovingUp;

  
    public float Speed = 2f;

    private bool _isFlying;

    private void Update()
    {
        if (_isFlying)
        {
            Fly();
        }
    }

    private void Fly()
    {
        float targetAngle = IsMovingUp ? FlyingAngle : FallingAngle;

        CurrentAngle = Mathf.Lerp(CurrentAngle, targetAngle, Time.deltaTime * 2f);

        transform.rotation = Quaternion.Euler(Vector3.forward * CurrentAngle);
        transform.Translate(Vector3.right * Speed * Time.deltaTime);



        if (Mathf.Abs(transform.position.y) > 2f)
        {
            GameManager.InitLoseGame();
        }
    }

    public void SetFlyingState(bool state)
    {
        _isFlying = state;
    }

    public void SetMovingState(bool state)
    {
        IsMovingUp = state;
    }
   /* void Update() {

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
    */

}
 