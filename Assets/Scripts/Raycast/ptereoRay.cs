using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ptereoRay : MonoBehaviour
{
    RaycastHit hit;

    public GameObject pterosaur;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(gameObject.transform.position, gameObject.transform.forward, out hit, 1000))
        {

            Debug.Log(hit.collider.name);
            if (hit.collider.name == "XR Rig")
            {
                pterosaur.SetActive(true);                
            }
            Debug.DrawRay(gameObject.transform.position, gameObject.transform.forward * hit.distance, Color.red);
        }
    }
}
