using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Faux : MonoBehaviour
{

    public float speed;
    private Transform playerPos;
    private Rigidbody rb;
    public GameObject effect;
    
    bool m_IsPlayerInRange;


    // Start is called before the first frame update
    void Start()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        rb = gameObject.GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (m_IsPlayerInRange)
        {
            //adds a force on this object in the direction of your target gameObject
            Vector3 dir = playerPos.transform.position - transform.position;
            dir = dir.normalized;
            rb.AddForce(dir * speed);
        }
        
        

        //If you want a constant speed, use the one below
        //transform.position = Vector3.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform == playerPos)
        {
            m_IsPlayerInRange = true;
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.transform == playerPos)
        {
            m_IsPlayerInRange = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            Destroy(gameObject);
            Instantiate(effect, transform.position, Quaternion.identity);
        }
    }

}
