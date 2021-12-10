using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

namespace UnityEngine.XR.Interaction.Toolkit{
public class BtnColorChange : MonoBehaviour
{
    public bool hoverStatus = false;
    public bool preHoverStatus = false;
    public GameObject Button;
    public RaycastHit RayHit; 
    public GameObject _XRIL_L;
    public GameObject _XRIL_R;
    Renderer HitbtnMat;
    public Renderer btnMat1;
    public Renderer btnMat2;
    public Renderer btnMat3;
    public Renderer btnMat4;
    public Renderer btnMat5;

    public AudioSource BtnSelect;
    public AudioClip Sound;
    Color color = new Color(0, 42, 64);
    Color Exitcolor = new Color(235, 5, 5);

    
    private XRRayInteractor LeftlineRenderable;
    private XRRayInteractor RightlineRenderable;

    // Start is called before the first frame update
    void Start()
    {
        LeftlineRenderable = _XRIL_L.GetComponent<XRRayInteractor>();
        RightlineRenderable = _XRIL_R.GetComponent<XRRayInteractor>();
    }

    // Update is called once per frame
    void Update()
    {
        if(LeftlineRenderable.TryGetCurrent3DRaycastHit(out RayHit))
        {
            Debug.Log(RayHit.collider.gameObject.name);
            //BtnSelect.Play();

            if(RayHit.collider.gameObject.name == "StartBox")
            {
                hoverStatus = true;
                btnMat1.material.SetColor("_EmissionColor", color * 0.01f);
                btnMat2.material.SetColor("_EmissionColor", color * -1f);
                btnMat3.material.SetColor("_EmissionColor", color * -1f);
                btnMat4.material.SetColor("_EmissionColor", Exitcolor * 0.01f);
                btnMat5.material.SetColor("_EmissionColor", color * -1f);
            }
            else if(RayHit.collider.gameObject.name == "GuideBox")
            {
                hoverStatus = true;
                btnMat1.material.SetColor("_EmissionColor", color * -1f);
                btnMat2.material.SetColor("_EmissionColor", color * 0.01f);
                btnMat3.material.SetColor("_EmissionColor", color * -1f);
                btnMat4.material.SetColor("_EmissionColor", Exitcolor * 0.01f);
                btnMat5.material.SetColor("_EmissionColor", color * -1f);
            }
            else if(RayHit.collider.gameObject.name == "OptionBox")
            {
                hoverStatus = true;
                btnMat1.material.SetColor("_EmissionColor", color * -1f);
                btnMat2.material.SetColor("_EmissionColor", color * -1f);
                btnMat3.material.SetColor("_EmissionColor", color *  0.01f);
                btnMat4.material.SetColor("_EmissionColor", Exitcolor * 0.01f);
                btnMat5.material.SetColor("_EmissionColor", color * -1f);
            }
            else if (RayHit.collider.gameObject.name == "ExitBox")
            {
                hoverStatus = true;
                btnMat1.material.SetColor("_EmissionColor", color * -1f);
                btnMat2.material.SetColor("_EmissionColor", color * -1f);
                btnMat3.material.SetColor("_EmissionColor", color * -1f);
                btnMat4.material.SetColor("_EmissionColor", Exitcolor * 0.001f);
                btnMat5.material.SetColor("_EmissionColor", color * -1f);
            }
            else if (RayHit.collider.gameObject.name == "BackBox")
            {
                hoverStatus = true;
                btnMat1.material.SetColor("_EmissionColor", color * -1f);
                btnMat2.material.SetColor("_EmissionColor", color * -1f);
                btnMat3.material.SetColor("_EmissionColor", color * -1f);
                btnMat4.material.SetColor("_EmissionColor", Exitcolor * 0.01f);
                btnMat5.material.SetColor("_EmissionColor", color * 0.01f);
            }
            else{
                hoverStatus = false;
                btnMat1.material.SetColor("_EmissionColor", color * -1f);
                btnMat2.material.SetColor("_EmissionColor", color * -1f);
                btnMat3.material.SetColor("_EmissionColor", color * -1f);
                btnMat4.material.SetColor("_EmissionColor", Exitcolor * 0.01f);
                btnMat5.material.SetColor("_EmissionColor", color * -1f);
            }
        }
        else
        {
            hoverStatus = false;
            btnMat1.material.SetColor("_EmissionColor", color * -1f);
            btnMat2.material.SetColor("_EmissionColor", color * -1f);
            btnMat3.material.SetColor("_EmissionColor", color * -1f);
            btnMat4.material.SetColor("_EmissionColor", Exitcolor * 0.01f);
            btnMat5.material.SetColor("_EmissionColor", color * -1f);
        }

        if(RightlineRenderable.TryGetCurrent3DRaycastHit(out RayHit))
        {
            Debug.Log(RayHit.collider.gameObject.name);
            //BtnSelect.Play();

            if(RayHit.collider.gameObject.name == "StartBox")
            {
                hoverStatus = true;
                btnMat1.material.SetColor("_EmissionColor", color * 0.01f);
                btnMat2.material.SetColor("_EmissionColor", color * -1f);
                btnMat3.material.SetColor("_EmissionColor", color * -1f);
                btnMat4.material.SetColor("_EmissionColor", Exitcolor * 0.01f);
                btnMat5.material.SetColor("_EmissionColor", color * -1f);
            }
            else if(RayHit.collider.gameObject.name == "GuideBox")
            {
                hoverStatus = true;
                btnMat1.material.SetColor("_EmissionColor", color * -1f);
                btnMat2.material.SetColor("_EmissionColor", color * 0.01f);
                btnMat3.material.SetColor("_EmissionColor", color * -1f);
                btnMat4.material.SetColor("_EmissionColor", Exitcolor * 0.01f);
                btnMat5.material.SetColor("_EmissionColor", color * -1f);
            }
            else if(RayHit.collider.gameObject.name == "OptionBox")
            {
                hoverStatus = true;
                btnMat1.material.SetColor("_EmissionColor", color * -1f);
                btnMat2.material.SetColor("_EmissionColor", color * -1f);
                btnMat3.material.SetColor("_EmissionColor", color *  0.01f);
                btnMat4.material.SetColor("_EmissionColor", Exitcolor * 0.01f);
                btnMat5.material.SetColor("_EmissionColor", color * -1f);
            }
            else if (RayHit.collider.gameObject.name == "ExitBox")
            {
                hoverStatus = true;
                btnMat1.material.SetColor("_EmissionColor", color * -1f);
                btnMat2.material.SetColor("_EmissionColor", color * -1f);
                btnMat3.material.SetColor("_EmissionColor", color * -1f);
                btnMat4.material.SetColor("_EmissionColor", Exitcolor * 0.001f);
                btnMat5.material.SetColor("_EmissionColor", color * -1f);
            }
            else if (RayHit.collider.gameObject.name == "BackBox")
            {
                hoverStatus = true;
                btnMat1.material.SetColor("_EmissionColor", color * -1f);
                btnMat2.material.SetColor("_EmissionColor", color * -1f);
                btnMat3.material.SetColor("_EmissionColor", color * -1f);
                btnMat4.material.SetColor("_EmissionColor", Exitcolor * 0.01f);
                btnMat5.material.SetColor("_EmissionColor", color * 0.01f);
            }
            else{
                hoverStatus = false;
                btnMat1.material.SetColor("_EmissionColor", color * -1f);
                btnMat2.material.SetColor("_EmissionColor", color * -1f);
                btnMat3.material.SetColor("_EmissionColor", color * -1f);
                btnMat4.material.SetColor("_EmissionColor", Exitcolor * 0.01f);
                btnMat5.material.SetColor("_EmissionColor", color * -1f);
            }
        }
        else
        {
            hoverStatus = false;
            btnMat1.material.SetColor("_EmissionColor", color * -1f);
            btnMat2.material.SetColor("_EmissionColor", color * -1f);
            btnMat3.material.SetColor("_EmissionColor", color * -1f);
            btnMat4.material.SetColor("_EmissionColor", Exitcolor * 0.01f);
            btnMat5.material.SetColor("_EmissionColor", color * -1f);
        }


        if(hoverStatus == true)
        {
            if(hoverStatus != preHoverStatus)
            {
                BtnSelect.PlayOneShot(Sound);
                preHoverStatus = hoverStatus;
            }
            
        }else
        {
            preHoverStatus = false;
        }
    }
} 
}

   

