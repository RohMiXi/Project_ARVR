using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class OculusMove : MonoBehaviour
{
    public XRController controller = null;
    private CharacterController character;
    private GameObject _camera;
    public float gravity = -20;
    float yVelocity = 0;
    public float speed= 5.0f;
    float maxspeed = 15.0f;
    float pl_speed = 0;
    float h_set = 0;
    float v_set = 0;


    private void Awake()
    {
        character = GetComponent<CharacterController>();
        _camera = GetComponent<XRRig>().cameraGameObject;
    }

    private void Update()
    {
        CommonInput();
        Debug.Log(pl_speed);
     
        //if (speed < maxspeed)
        //{
        //   speed += 0.02f;
        //}
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
            character.Move(motion: newDirection * Time.deltaTime * speed);
        }

        //keyboard
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if (h > 0)
        {
            h_set += Time.deltaTime;
            if (h_set >= 1)
            {
                h_set = 1;
            }
        }
        else if (h < 0)
        {
            h_set -= Time.deltaTime;
            if (h_set <= -1)
            {
                h_set = -1;
            }
        }
        else
        {
            if(h_set > 0)
            {
                h_set -= Time.deltaTime;

            }
            else if(h_set <0)
            {
                h_set += Time.deltaTime;
            }
            else
            {
                h_set = 0;
            }
        }

        if (v > 0)
        {
            v_set += Time.deltaTime;
            if (v_set >= 1)
            {
                v_set = 1;
            }
        }
        else if (v < 0)
        {
            v_set -= Time.deltaTime;
            if (v_set <= -1)
            {
                v_set = -1;
            }
        }
        else
        {
            if (v_set > 0)
            {
                v_set -= Time.deltaTime;

            }
            else if (v_set < 0)
            {
                v_set += Time.deltaTime;
            }
            else
            {
                v_set = 0;
            }
        }





        Vector3 dir = new Vector3(h_set, 0, v_set);
        dir = Camera.main.transform.TransformDirection(dir);
        yVelocity += gravity * Time.deltaTime;
        if (character.isGrounded)
        {
            yVelocity = 0;
        }
        dir.y = yVelocity;

        if (h != 0f || v != 0f)
        {
            pl_speed += 2 * Time.deltaTime;
            if (pl_speed >= speed)
            {
                pl_speed = speed;
            }
        }
        else
        {
            pl_speed -= 5 * Time.deltaTime;
            if (pl_speed <= 0)
            {
                pl_speed = 0;
            }
        }     
        
        character.Move(dir * Time.deltaTime * pl_speed);
    }
    /*
    public Animation anim;

    private bool isWalking;
    private Vector3 lastPosition;

    private void CheckPosition()
    {
        if (lastPosition != gameObject.transform.position)
        {
            isWalking = true;
        }
        else
        {
            isWalking = false;
        }
        lastPosition = gameObject.transform.position;
    }

    void CameraAnimation()
    {
        if (character.isGrounded == true)
        {
            if (isWalking == true)
            {
                anim.Play("headbob");
            }
        }
    }
    */

}