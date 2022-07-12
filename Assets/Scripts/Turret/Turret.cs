using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform Player;

    public float respawnTime = 0f;
    // Start is called before the first frame update
    void Start()
    {
        respawnTime = 1.5f;
    }

    private float timer = 0f;
    
    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("¸ñÇ¥ Æ÷Âø");

        if (other.tag != "Player")
        {
            return;
        }

        if (timer >= respawnTime)
        {
            GameObject bullet = Instantiate(BulletPrefab, transform);
            bullet.transform.LookAt(Player);

            timer = 0f;
        }
    }
}
