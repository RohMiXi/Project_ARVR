using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalGlowRay : MonoBehaviour
{
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
