using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballmovement : MonoBehaviour
{
    // public GameObject[] waypoint;
    public Transform target;
    //public float t;
    public float speed;
    // int current = 0; // 현재 오브젝트가 있는 위치. 
    // float WPradius = 1;


    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 a = transform.position;
        Vector3 b = target.position;
        transform.position = Vector3.MoveTowards(a,b, speed);

        // if(Vector3.Distance(waypoint[current].transform.position, transform.position) < WPradius)
        // {
        //     current++;
        //     if(current >= waypoint.Length)
        //     {
        //         current = 0;
        //     }
        // }
        // transform.position = Vector3.MoveTowards(transform.position, waypoint[current].transform.position, Time.deltaTime * speed);

    }
}
