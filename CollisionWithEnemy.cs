using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithEnemy : MonoBehaviour
{

    public PlayerMovement movement;
    public GameObject effect;

    public int health;
    public int damage;

    public GameManager gameManager;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Enemy")
        {
            //movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            Destroy(gameObject);
            Instantiate(effect, transform.position, Quaternion.identity);

            gameManager.Death();
        }

        
    }
}
