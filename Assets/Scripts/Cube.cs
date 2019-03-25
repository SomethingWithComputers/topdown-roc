using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private float _rotationSpeed = 0.0f;

    private void Start()
    {
        GetComponent<Hittable>().OnHit += damage => { _rotationSpeed = 320.0f; };
    }

    private void Update()
    {
        Vector3 rotation = transform.eulerAngles;

        rotation.y += _rotationSpeed;

        _rotationSpeed *= 0.9f;
        transform.eulerAngles = rotation;
    }
}