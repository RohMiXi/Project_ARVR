using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    Rigidbody body;
    float timer = 1.0f;
    //int i = 0;

    void Start() {
        body = GetComponent<Rigidbody>();
        //body.useGravity = false; //중력을 사용하지 않도록 구현. 
        //body.velocity = Vector3.right * 0.2f;   //물체 속도 추가. 
    }
    void Update() 
    {
        //transform.Translate(new Vector3(0, 50, 0));
        //MoveTranslate(new Vector3(0f, Mathf.Cos(timer), 0f));

        // if(Input.GetKeyDown(KeyCode.A)&&check)
        // {
        //     check = false;
        //     print("Inside" + i++);
        //     StartCoroutine(WaitForIt());
        // }
    }
    // IEnumerator WaitForIt()
    // {
    //     yield return new WaitForSeconds(2.0f);
    //     check = true;
    // }
    // private void MoveTranslate(Vector3 moveVector)
    // {
    //     transform.Translate(moveVector);
    // }

    // private void MovePosition(Vector3 newPos)
    // {
    //     transform.position = newPos;
    // }
    void FixedUpdate() { //일정한 시간이 될 경우, 속도를 0으로 줄여줌. 
        timer -= Time.deltaTime;
        if(timer < 0)
        {
            body.AddForce(new Vector3(0, 500.0f, 0));
            timer = 100.0f;
        }    
    }
}
