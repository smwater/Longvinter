using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatement : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet")
        {
            Die();
        }
    }

    public void Die()
    {
        gameObject.SetActive(false);
    }
}
