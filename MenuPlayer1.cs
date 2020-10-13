using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPlayer1 : MonoBehaviour
{

    public GameObject effect;
    public GameObject player;
    public GameObject spawn;
    public MenuGameManager menuGameManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "Enemy")
        {
            FindObjectOfType<MenuGameManager>().ThingDied();
            Destroy(gameObject);
            Instantiate(effect, transform.position, Quaternion.identity);

            Instantiate(player, spawn.transform.position, Quaternion.identity);

        }
    }

    void Respawn ()
    {
        Instantiate(player, spawn.transform.position, Quaternion.identity);
    }
}
