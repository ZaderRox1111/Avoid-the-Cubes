using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuGameManagerEnemies : MonoBehaviour
{

    bool thingHasDied = false;
    public float restartDelay;
    public Transform[] spawnSpots;
    public GameObject cube;

    public void ThingDied()
    {
        if (thingHasDied == false)
        {
            thingHasDied = true;

            Invoke("Restart", restartDelay);
        }
    }

    public void Restart()
    {
        int randPos = Random.Range(0, spawnSpots.Length - 1);
        Instantiate(cube, spawnSpots[randPos].position, Quaternion.identity);
        Instantiate(cube, spawnSpots[randPos+1].position, Quaternion.identity);
    }

}
