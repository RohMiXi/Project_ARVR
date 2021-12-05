using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class volumesibal : MonoBehaviour
{
    GameObject PopupCanvas;
    public AudioSource sibal;
    // Start is called before the first frame update
    void Start()
    {
        PopupCanvas = GameObject.Find("Popup Canvas");
        sibal.volume = (float)PopupCanvas.GetComponent<scenechange>().valuenum / 100;

    }

    // Update is called once per frame
    void Update()
    {
    }
}
