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
    float maxspeed = 5.0f;
    public AudioSource swim;   
    public xrrigdamage _XRD;
    public damagexrrig1 _DXG;
    public rockdamage _RDG;
    public rockdamage1 _RDG1;
    public rockdamage2 _RDG2;

    public speedfast _SFT;
    private float count = 2f;
    private bool back;
    //private bool fastfast;
    private bool swimming;
    //xrring의 이전 포지션;
    Vector3 latePosition;
    Vector3 direction;

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;
        if (body == null || body.isKinematic)
        {
            return;           
        }

        else
        {
            //Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
            //body.velocity = pushDir * pushPower;
            Debug.Log("hit");
        }






        // Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
        //body.velocity = pushDir * pushPower;
    }





    private void Awake()
    {
        
        character = GetComponent<CharacterController>();
        _camera = GetComponent<XRRig>().cameraGameObject;
        



    }

    private void Update()
    {
        direction = Camera.main.transform.TransformDirection(direction);
        CommonInput();
        if (latePosition != transform.position)
        {
            Debug.Log("작동");
            swimming = true;
            //if (swimming == true)
            //{
            //   swim.Play();
            //}
            if (swim.isPlaying == false)
            {
                swim.Play();
            }


        }
        else
        {
            if(swim.isPlaying == true)
            {
                swim.Stop();
            }
            if(_SFT.fastrange == true)
            {
                character.Move(direction * Time.deltaTime * speed * 2);
            }
        }
        

        //제일 마지막에 업데이트해줘야함
        latePosition = transform.position;
        



        //if (Input.GetKey("w"))
        //{
        //   if(speed < maxspeed)
        // {
        //     speed += 0.025f;
        // }

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
            if (_XRD.inthefire == true)
            {
                
                character.Move(motion: newDirection * Time.deltaTime * -speed);
                back = true;
            }
            else
            {
                if (back == true)
                {
                    character.Move(motion: newDirection * Time.deltaTime * -speed);
                    
                    count -= Time.deltaTime;
                    if (count < 0)
                    {

                        back = false;
                        count = 2f;
                    }
                }
                else
                {
                    character.Move(motion: newDirection * Time.deltaTime * speed);
                    
                }

            }
            character.Move(motion: newDirection * Time.deltaTime * speed);
        }
        float H = Input.GetAxis("3rd axis");
        float V = Input.GetAxis("4th axis");
        Vector3 direction = new Vector3(H, 0, V);
        transform.Rotate(direction * Time.deltaTime);
        //keyboard
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 dir = new Vector3(h, 0, v);
        dir = Camera.main.transform.TransformDirection(dir);
        yVelocity += gravity * Time.deltaTime;
        if (character.isGrounded)
        {
            yVelocity = 0;
        }
        dir.y = yVelocity;

        if (_XRD.inthefire == true)
        {
             
            character.Move(dir * Time.deltaTime * -speed);
            //character.Move(motion: newDirection * Time.deltaTime * speed);
            back = true;
        }
        if (_DXG.inthefire == true)
        {

            character.Move(dir * Time.deltaTime * -speed);
            //character.Move(motion: newDirection * Time.deltaTime * speed);
            back = true;
        }
        if (_RDG.inthefire == true)
        {

            character.Move(dir * Time.deltaTime * -speed);
            
            back = true;
        }
        if (_RDG1.inthefire == true)
        {

            character.Move(dir * Time.deltaTime * -speed);

            back = true;
        }
        if (_RDG2.inthefire == true)
        {

            character.Move(dir * Time.deltaTime * -speed);

            back = true;
        }

        else
        {
            if (back == true)
            {
                dir.y = 0;
                if (dir.z >= 0)
                {
                    dir.z = -1;
                }
                character.Move(dir * Time.deltaTime * -speed);
                count -= Time.deltaTime;
                if (count < 0)
                {

                    back = false;
                    count = 2f;
                }
            }
            else
            {
                if (_SFT.fastrange == true)
                {

                    character.Move(dir * Time.deltaTime * speed * 2);

                }
                else
                {
                    character.Move(dir * Time.deltaTime * speed);
                }
                //character.Move(dir * Time.deltaTime * speed);

            }
            
            
        }
        /*if (_SFT.fastrange == true)
        {

            character.Move(dir * Time.deltaTime * speed * 2);
            
        }
        else
        {
            character.Move(dir * Time.deltaTime * speed);
        }*/

        


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