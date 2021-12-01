using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotate : MonoBehaviour
{
    //���簢��
    Vector3 angle;
    //���콺 ����
    public float sensitivity = 200;
    // Start is called before the first frame update
    void Start()
    {
        angle.y = -Camera.main.transform.eulerAngles.x;
        angle.x = Camera.main.transform.eulerAngles.y;
        angle.z = Camera.main.transform.eulerAngles.z;

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Mouse X");
        float y = Input.GetAxis("Mouse Y");
        angle.x += x * sensitivity * Time.deltaTime;
        angle.y += y * sensitivity * Time.deltaTime;
        transform.eulerAngles = new Vector3(-angle.y, angle.x, transform.eulerAngles.z);

    }
}
