using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class OculusMove : MonoBehaviour
{
    public XRController controller = null;
    public XRController rightcontroller = null;
    private CharacterController character;
    private GameObject _camera;
    public float gravity = -20;
    float yVelocity = 0;
    public float speed = 5.0f;
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
    private bool waterfall;
    //private bool fastfast;
    private bool swimming;
    //xrring�� ���� ������;
    Vector3 latePosition;
    void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;
        if (body == null || body.isKinematic)
        {
            return;
        }

        else
        {
            Debug.Log("hit");
        }







    }





    private void Awake()
    {

        character = GetComponent<CharacterController>();
        _camera = GetComponent<XRRig>().cameraGameObject;




    }

    private void Update()
    {

        CommonInput();
        if (latePosition != transform.position)
        {
            Debug.Log("�۵�");
            swimming = true;

            if (swim.isPlaying == false)
            {
                swim.Play();
            }


        }
        else
        {
            if (swim.isPlaying == true)
            {
                swim.Stop();
            }

        }



        latePosition = transform.position;





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
            if (_DXG.inthefire == true)
            {

                character.Move(motion: newDirection * Time.deltaTime * -speed);

                back = true;
            }
            if (_RDG.inthefire == true)
            {

                character.Move(motion: newDirection * Time.deltaTime * -speed);

                back = true;
            }
            if (_RDG1.inthefire == true)
            {

                character.Move(motion: newDirection * Time.deltaTime * -speed); 

                back = true;
            }
            if (_RDG2.inthefire == true)
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
                        newDirection.y = 0;

                        back = false;
                        count = 2f;
                    }
                }
                else
                {
                    if (_SFT.fastrange == true)
                    {

                        character.Move(motion: newDirection * Time.deltaTime * speed * 2.5f);
                        waterfall = true;
                        if (waterfall == true)
                        {
                            if (newDirection.z >= 0)
                            {
                                newDirection.z = -1;
                                newDirection.x =  1f;
                            }
                            character.Move(motion: newDirection * Time.deltaTime * speed * 2.5f);
                            count -= Time.deltaTime;
                            if (count < 0)
                            {
                                waterfall = false;
                                count = 2f;
                            }
                        }




                    }
                    else
                    {
                        character.Move(motion: newDirection * Time.deltaTime * speed);
                    }
                    //character.Move(motion: newDirection * Time.deltaTime * speed);
                }

            }
            //character.Move(motion: newDirection * Time.deltaTime * speed);
        }
        
        /*if (rightcontroller.inputDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 pos))
        {

            float angle = Mathf.Atan2(pos.x, -pos.y) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Euler(0, angle, 0);
        }*/

        
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

            back = true;
        }
        if (_DXG.inthefire == true)
        {

            character.Move(dir * Time.deltaTime * -speed);

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
                    dir.x = -0.5f;
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
                    waterfall = true;
                    if (waterfall == true)
                    {
                        dir.y = 0;
                        if (dir.z >= 0)
                        {
                            dir.x = 1;
                            dir.z = -1;
                        }
                        character.Move(dir * Time.deltaTime * speed * 2);
                        count -= Time.deltaTime;
                        if (count < 0)
                        {
                            waterfall = false;
                            count = 2f;
                        }
                    }




                }
                else
                {
                    character.Move(dir * Time.deltaTime * speed);
                }


            }


        }
        





    }



}