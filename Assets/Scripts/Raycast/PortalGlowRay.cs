using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalGlowRay : MonoBehaviour
{
    RaycastHit hit;
    public GameObject Player;
    public GameObject Portal;
    private float Dist;
    private float intensity;
    Renderer portalMat;
    // Start is called before the first frame update

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Dist = Vector3.Distance(Player.transform.position, Portal.transform.position);
        if (Physics.Raycast(gameObject.transform.position, gameObject.transform.forward, out hit, 1000))
        {
            if(hit.collider.name == "XR Rig")
            {
                Debug.Log(hit.collider.name);
               
            }
            Debug.DrawRay(gameObject.transform.position, gameObject.transform.forward * hit.distance, Color.red);
        }
        Debug.Log(Dist);
        GlowPortal();
    }

    void GlowPortal()
    {
        portalMat = Portal.GetComponent<Renderer>();
        if  (Dist <= 100 )
        {
            intensity = (1.0f - Dist / 80.0f) * (200 / Dist);
            portalMat.material.SetColor("_EmissionColor", Color.white * intensity);
        }
    }
}
