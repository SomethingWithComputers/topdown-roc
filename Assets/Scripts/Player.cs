using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    [SerializeField] private float _strength = 4.0f;

    private Rigidbody2D _rigidbody2D;

    // Start is called before the first frame update
    protected void Start()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    protected void Update()
    {
        Vector2 force = new Vector2();
        if (Input.GetKey(KeyCode.A))
        {
            force.x = -1.0f;
        }

        if (Input.GetKey(KeyCode.D))
        {
            force.x = 1.0f;
        }

        if (Input.GetKey(KeyCode.W))
        {
            force.y = 1.0f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            force.y = -1.0f;
        }


        _rigidbody2D.AddForce(force.normalized * _strength);
    }
}