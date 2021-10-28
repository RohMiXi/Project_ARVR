using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VoxelMaker : MonoBehaviour
{
    //���� ����
    public GameObject voxelFactory;
    //������Ʈ Ǯ�� ũ��
    public int voxelPoolSize = 20;
    //������Ʈ Ǯ
    public static List<GameObject> voxelPool = new List<GameObject>();
    public float createTime = 0.1f;
    float currentTime = 0;
    //ũ�ν���� ����
    public Transform crosshair;
    // Start is called before the first frame update
    void Start()
    {
        //������Ʈ Ǯ�� ��Ȱ��ȭ�� ������ ��� �ʹ�.
        for (int i = 0; i < voxelPoolSize; i++)
        {
            //���� ���忡�� ���� �����ϱ�
            GameObject voxel = Instantiate(voxelFactory);
            //���� ��Ȱ��ȭ�ϱ�
            voxel.SetActive(false);
            //������ ������Ʈ Ǯ�� ��� �ʹ�.
            voxelPool.Add(voxel);
        }

    }

    // Update is called once per frame
    void Update()
    {
        //ũ�ν���� �׸���
        ARAVRInput.DrawCrosshair(crosshair);
        //VR ��Ʈ�ѷ��� �߻� ��ư�� ������
        if (ARAVRInput.Get(ARAVRInput.Button.One))
        {
            currentTime += Time.deltaTime;
            if (currentTime > createTime)
            {
                //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                //��Ʈ�ѷ��� ���ϴ� �������� �ü� �����
                Ray ray = new Ray(ARAVRInput.RHandPosition, ARAVRInput.RHandDirection);

                RaycastHit hitInfo = new RaycastHit();
                if (Physics.Raycast(ray, out hitInfo))
                {
                    //���� ������Ʈ Ǯ �̿��ϱ�
                    //���� ������Ʈ Ǯ�� ������ �ִٸ�
                    if (voxelPool.Count > 0)
                    {
                        currentTime = 0;
                        //������Ʈ Ǯ���� ������ �ϳ� �����´�
                        GameObject voxel = voxelPool[0];
                        //������ Ȱ��ȭ�Ѵ�
                        voxel.SetActive(true);
                        //������ ��ġ�ϰ� �ʹ�.
                        voxel.transform.position = hitInfo.point;
                        //������Ʈ Ǯ���� ������ �����Ѵ�
                        voxelPool.RemoveAt(0);
                    }

                }

            }
        }
    }
}