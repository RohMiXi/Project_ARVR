using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voxel : MonoBehaviour
{
    //������ ������ �������� ���ư��� ��� �Ѵ�.
    //�ʿ� �Ӽ�: ���ư� �ӵ�
    public float speed = 5;
    //������ ������ �ð�
    public float destroyTime = 3.0f;
    //����ð�
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
        //���� �ð��� ������ ������ �����ϰ� �ʹ�.
        //�ð��� �귯�� �Ѵ�
        currentTime += Time.deltaTime;
        //���Žð��� �����ϱ�
        //���� ����ð��� ���Žð��� �ʰ��ߴٸ�
        if (currentTime > destroyTime)
        {
            gameObject.SetActive(false);
            VoxelMaker.voxelPool.Add(gameObject);
        }
    }
}

