using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class oculusmove2 : MonoBehaviour
{
    public XRController controller = null;
    private CharacterController character;
    private GameObject _camera;
    public float gravity = -20;
    float yVelocity = 0;
    Rigidbody rb;
    float power = 8f;
    //float maxspeed = 15.0f;







    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        character = GetComponent<CharacterController>();
        _camera = GetComponent<XRRig>().cameraGameObject;
    }

    private void Update()
    {
        CommonInput();
       
    }

    private void CommonInput()
    {
        // Touchpad/Joystick position
        if (controller.inputDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 position))
        {
            var inputVector = new Vector3(-position.x, Physics.gravity.y, z: -position.y);
            var inputDirection = transform.TransformDirection(inputVector);
            var lookDirection = new Vector3(x: 0, _camera.transform.eulerAngles.y, z: 0);
            var newDirection = Quaternion.Euler(lookDirection) * inputDirection;
            character.Move(motion: newDirection * Time.deltaTime * 5f);
        }
        //keyboard
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(h, 0, v);
        dir = Camera.main.transform.TransformDirection(dir);
        rb.AddForce(dir * power);
        yVelocity += gravity * Time.deltaTime;
        if (character.isGrounded)
        {
            yVelocity = 0;
        }
         dir.y = yVelocity;



        //character.Move(dir * Time.deltaTime * speed);
    }
}
