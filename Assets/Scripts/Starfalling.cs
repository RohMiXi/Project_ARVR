using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Starfalling : MonoBehaviour
{
    // Start is called before the first frame update

    public Vector3 _posA;
    public Vector3 _posB;
    void FixedUpdate() {
        transform.position = Vector3.Lerp(transform.position, _posB, Time.deltaTime);
    }

    // Update is called once per frame
}
