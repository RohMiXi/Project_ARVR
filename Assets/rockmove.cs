using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockmove : MonoBehaviour
{

    public float speed = 10f;
    Transform XRRig;
    public float attackRange = 10;
    // Start is called before the first frame update
    void Start()
    {

        XRRig = GameObject.Find("XR Rig").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, XRRig.position) < attackRange)
        {
            //FindObjectOfType<Audio_Manager>().Play("rockappear");
            transform.position = Vector3.MoveTowards(transform.position,
                new Vector3(-26f, -32f, -124f), Time.deltaTime * speed);
            

        }
    }
}
