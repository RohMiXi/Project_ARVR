using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class dinosaurfire : MonoBehaviour
{

    public ParticleSystem particle;

    Transform XRRig;
    public float attackRange = 50;

    // Start is called before the first frame update
    void Start()
    {
        particle.Stop();
        XRRig = GameObject.Find("XR Rig").transform;
    }

    // Update is called once per frame
    void Update()
    {

        if (Vector3.Distance(transform.position, XRRig.position) < attackRange)
        {
            if (particle)
            {
                if (particle.isPlaying == false)
                {
                    particle.Play();
                }
            }
        }
    }
}