using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuEnemy : MonoBehaviour
{
    public float speed;
    private Transform playerPos;
    private Rigidbody rb;
    public GameObject effect;
    public Transform[] spawnSpots;
    public GameObject enemy;


    // Start is called before the first frame update
    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        rb = gameObject.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //adds a force on this object in the direction of your target gameObject
        Vector3 dir = playerPos.transform.position - transform.position;
        dir = dir.normalized;
        rb.AddForce(dir * (speed));

        //If you want a constant speed, use the one below
        //transform.position = Vector3.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
    }

    private void Update()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            FindObjectOfType<MenuGameManagerEnemies>().ThingDied();
            Destroy(gameObject);
            Instantiate(effect, transform.position, Quaternion.identity);
            int randPos = Random.Range(0, spawnSpots.Length - 1);
            Instantiate(enemy, spawnSpots[randPos].position, Quaternion.identity);

        }
    }

    void Respawn()
    {
        int randPos = Random.Range(0, spawnSpots.Length - 1);
        Instantiate(enemy, spawnSpots[randPos].position, Quaternion.identity);
    }
}
