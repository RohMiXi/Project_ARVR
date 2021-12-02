using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Starfalling : MonoBehaviour
{
    // Start is called before the first frame update

    public float _posA;
    public float _posB;
    void FixedUpdate() {
        transform.position = new Vector3(Mathf.Lerp(_posA, _posB, Time.time),0, 0);
    }

    // Update is called once per frame
}
