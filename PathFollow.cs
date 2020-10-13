using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollow : MonoBehaviour
{

    // put the points from unity interface
    public Transform[] wayPointList;

    public int currentWayPoint = 0;
    Transform targetWayPoint;
    public Rigidbody rb;
    public float closenessFactor;

    
    
    public float speed = 4f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // check if we have somewere to walk
        if (currentWayPoint < this.wayPointList.Length)
        {
            if (targetWayPoint == null)
                targetWayPoint = wayPointList[currentWayPoint];
            walk();
        }
    }

    void walk()
    {
        // rotate towards the target
        //transform.forward = Vector3.RotateTowards(transform.forward, targetWayPoint.position - transform.position, speed * Time.deltaTime, 0.0f);

        // move towards the target
        // transform.position = Vector3.MoveTowards(transform.position, targetWayPoint.position,   speed*Time.deltaTime);
        Vector3 dir = targetWayPoint.position - transform.position;
        dir = dir.normalized;
        rb.AddForce(dir * (speed));

        if ((targetWayPoint.position - transform.position).magnitude < closenessFactor)
        {
            currentWayPoint = (currentWayPoint + 1) % wayPointList.Length ;
            targetWayPoint = wayPointList[currentWayPoint];
        }
    }
}
