using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockmove : MonoBehaviour
{
    public ParticleSystem particle;
    public float speed = 10f;
    Transform XRRig;
    public float attackRange = 10;
    public AudioSource a;
    float count = 1f;
    float c = 1;
    Vector3 vel = Vector3.zero;
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

            //FindObjectOfType<Audio_Manager>().Play("rockappear");
            //transform.position = Vector3.Lerp(transform.position,
            //   new Vector3(-26f, -32f, -124f), 0.3f);
            transform.position = Vector3.SmoothDamp(transform.position, new Vector3(-26f, -32f, -124f), ref vel, 0.3f);
            if (count >= 1f && count <= 5)
            {
                
                if (count == 1)
                {

                    particle.Play();


                }
                count += 1f;

            }






            if (count >= 1f && count <= 5)
            {
                count += 1f;
                if (count == 5)
                {

                    a.Play();


                }
               
            }



            }
    }
}
