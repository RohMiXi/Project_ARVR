using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voxel : MonoBehaviour
{
    //복셀은 랜덤한 방향으로 날아가는 운동을 한다.
    //필요 속성: 날아갈 속도
    public float speed = 5;
    //복셀을 제거할 시간
    public float destroyTime = 3.0f;
    //경과시간
    float currentTime;
    // Start is called before the first frame update
    void OnEnable()
    {
        currentTime = 0;
        Vector3 direction = Random.insideUnitSphere;
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();
        rb.velocity = direction * speed;
    }



    // Update is called once per frame
    void Update()
    {
        //일정 시간이 지나면 복셀을 제거하고 싶다.
        //시간이 흘러야 한다
        currentTime += Time.deltaTime;
        //제거시간이 됐으니까
        //만약 경과시간이 제거시간을 초과했다면
        if (currentTime > destroyTime)
        {
            gameObject.SetActive(false);
            VoxelMaker.voxelPool.Add(gameObject);
        }
    }
}

