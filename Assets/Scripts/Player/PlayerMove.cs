using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private float _speed = 3f;
    // Update is called once per frame
    void Update()
    {
        float xInput;
        float zInput;

        xInput = zInput = 0f;

        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");

        float xSpeed = xInput * _speed;
        float zSpeed = zInput * _speed;

        _rigidbody.AddForce(xSpeed, 0, zSpeed);
    }
}
