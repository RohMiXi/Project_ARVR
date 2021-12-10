using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rockdamage : MonoBehaviour
{
    
    Transform XRRig;
    public float rockRange = 10;
    public bool inthefire;

    
    // Start is called before the first frame update
    void Start()
    {
        
        XRRig = GameObject.Find("XR Rig").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, XRRig.position) < rockRange)
        {
            
            inthefire = true;

        }
        else
        {
            inthefire = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Ãæµ¹");
    }


}
