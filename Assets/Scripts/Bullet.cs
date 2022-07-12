using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float _speed = 0.03f;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, 0f, _speed);
    }
}
