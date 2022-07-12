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

        transform.Rotate(new Vector3(0f, 0.1f, 0f));
    }

    private Vector3 playerPosition;

    private void OnTriggerStay(Collider other)
    {
        if (other.tag != "Player")
        {   
            return;
        }

        Debug.Log("¸ñÇ¥ Æ÷Âø");
        playerPosition = new Vector3(Player.position.x, transform.position.y, Player.position.z);
        gameObject.transform.LookAt(playerPosition);

        if (timer >= respawnTime)
        {   
            GameObject bullet = Instantiate(BulletPrefab, transform);            
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
