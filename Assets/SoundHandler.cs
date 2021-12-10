using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundHandler : MonoBehaviour
{
    
    public AudioClip keyClick;
    private AudioSource clickSource;
    
    // Start is called before the first frame update
    void Start()
    {
        clickSource = gameObject.AddComponent<AudioSource>();
    }

    // Update is called once per frame
    public void PlayKeyClick()
    {
        clickSource.PlayOneShot(keyClick);
    }
}
