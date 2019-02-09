using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTimeObject : MonoBehaviour
{

    [SerializeField]
    float Lifetime = 2f;

    void Start()
    {
        Destroy(gameObject, Lifetime);
    }
}