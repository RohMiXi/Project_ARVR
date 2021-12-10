using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rockmove3 : MonoBehaviour
{
    public ParticleSystem particle;
    public float speed = 10f;
    Transform XRRig;
    public float attackRange = 10;
    public AudioSource a;
    float count = 1f;
    Vector3 vel = Vector3.zero;
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
            //transform.position = Vector3.MoveTowards(transform.position,
            //    new Vector3(-61.01f, -38.74193f, -147.84f), Time.deltaTime * speed);
            transform.position = Vector3.SmoothDamp(transform.position, new Vector3(-61.01f, -38.74193f, -147.84f), ref vel, 0.3f);


            if (count >= 1f && count <= 5)
            {
                count += 1f;
                if (count == 5)
                {
                    particle.Play();
                    a.Play();


                }

            }



        }
    }
}
