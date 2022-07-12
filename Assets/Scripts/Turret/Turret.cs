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

    private void OnTriggerStay(Collider other)
    {
        if (other.tag != "Player")
        {
            return;
        }

        Debug.Log("¸ñÇ¥ Æ÷Âø");
        gameObject.transform.LookAt(Player);

        if (timer >= respawnTime)
        {
            GameObject bullet = Instantiate(BulletPrefab);
            bullet.transform.LookAt(Player);

            timer = 0f;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player")
        {
            return;
        }

        
    }
}
