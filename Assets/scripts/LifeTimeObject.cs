using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTimeObject : MonoBehaviour
{

    [SerializeField]
    float Lifetime = 2f;

    // Use this for initialization
    void Start()
    {
        Destroy(gameObject, Lifetime);
    }
}