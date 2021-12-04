using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class value : MonoBehaviour
{
    public scenechange sc;
    public Slider a;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sc.valuenum = a.value;
        if (sc.valuenum >= 0) sc.call(); 
    }
}
