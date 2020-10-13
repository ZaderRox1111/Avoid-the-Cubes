using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject[] obstacle;

    public Vector3 center;
    public Vector3 size;
    public int amountOfObstacles;



    // Start is called before the first frame update
    void Start()
    {

        SpawnObstacle();

    }

    public void SpawnObstacle()
    {

        for (int i = 0; i < amountOfObstacles; i++)
        {
            Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), 0.5f, Random.Range(-size.z / 2, size.z / 2));
            Quaternion rot = Quaternion.Euler(Random.Range(0, 30), Random.Range(0, 360), Random.Range(0, 30));

            int randObstacle = Random.Range(0, obstacle.Length);
            Instantiate(obstacle[randObstacle], pos, rot);
        }
        

        
    }
    
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        Gizmos.DrawCube(center, size);
    }






}
