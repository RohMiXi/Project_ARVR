using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class mainmenusound : MonoBehaviour
{
    
    public Slider a;
    public AudioSource mainmenubgm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mainmenubgm.volume = a.value / 100;
    }
}
