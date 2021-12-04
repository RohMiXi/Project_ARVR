using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

    public class BtnColorChange : MonoBehaviour
{
    public bool hoverStatus;
    public GameObject Button;
    Renderer btnMat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(hoverStatus);
        btnMat = Button.GetComponent<Renderer>();
        if (hoverStatus)
        {
            btnMat.material.SetColor("_EmissionColor", Color.white * 2.5f);
        }
    }

    protected bool isUISelectActive
    {
        get => hoverStatus; 
    }
} 

   

