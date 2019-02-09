using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform TrackedObject;
    public float OffsetX;

    public bool IsCameraMoving = true;

    private bool _isLerping;
    private Vector3 _startLerpPosition;
    private Vector3 _endLerpPosition;

    private float _timer;
    private float _lerpTime;

    private void Update()
    {
        if (IsCameraMoving)
        {
            transform.position = new Vector3(TrackedObject.position.x + OffsetX, transform.position.y, transform.position.z);
        }

        if (_isLerping)
        {
            _timer += Time.deltaTime;
            if(_timer >= _lerpTime)
            {
                StopLerping();
            }
            else
            {
                transform.position = Vector3.Lerp(_startLerpPosition, _endLerpPosition, _timer / _lerpTime);
            }
        }
    }

    public void StartLerpingToTrackedObject(float lerpTime, Vector3 endLerpPos)
    {
        _timer = 0;
        _lerpTime = lerpTime;
        _startLerpPosition = transform.position;
        _endLerpPosition = new Vector3(TrackedObject.position.x + OffsetX, transform.position.y, transform.position.z);
        Debug.Log(_startLerpPosition);
        Debug.Log(_endLerpPosition);
        _isLerping = true;
    }

    public void StopLerping()
    {
        _lerpTime = 0;
        _timer = 0;
        _isLerping = false;
    }

    public void StopCamera()
    {
        IsCameraMoving = false;
    }

    public void ResumeCamera()
    {
        IsCameraMoving = true;
    }
}
