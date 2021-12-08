using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speedfast : MonoBehaviour
{
    Transform XRRig;
    public float fastRange = 10;
    public bool fastrange;
    // Start is called before the first frame update
    void Start()
    {
        XRRig = GameObject.Find("XR Rig").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, XRRig.position) < fastRange)
        {
            
            fastrange = true;

        }
        else
        {
            fastrange = false;
        }
    }
}
