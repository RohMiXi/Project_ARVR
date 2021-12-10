using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;


public class headrotate : MonoBehaviour
{
    public XRController rightcontroller = null;
    private CharacterController character;
    private GameObject _camera;
    private float count = 2f;
    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
        _camera = GetComponent<XRRig>().cameraGameObject;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (rightcontroller.inputDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 pos))
        {

            float angle = Mathf.Atan2(pos.x, pos.y) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, angle, 0);
        }*/
        if (rightcontroller.inputDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 pos))
        {
            var inputVector = new Vector3(-pos.x, 0, z: -pos.y);
            float angle = Mathf.Atan2(pos.x, pos.y) * Mathf.Rad2Deg;

            transform.Rotate(inputVector * angle);
        }
    }
}
