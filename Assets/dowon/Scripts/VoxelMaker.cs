using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class VoxelMaker : MonoBehaviour
{
    //복셀 공장
    public GameObject voxelFactory;
    //오브젝트 풀의 크기
    public int voxelPoolSize = 20;
    //오브젝트 풀
    public static List<GameObject> voxelPool = new List<GameObject>();
    public float createTime = 0.1f;
    float currentTime = 0;
    //크로스헤어 변수
    public Transform crosshair;
    // Start is called before the first frame update
    void Start()
    {
        //오브젝트 풀에 비활성화된 복셀을 담고 싶다.
        for (int i = 0; i < voxelPoolSize; i++)
        {
            //복셀 공장에서 복셀 생성하기
            GameObject voxel = Instantiate(voxelFactory);
            //복셀 비활성화하기
            voxel.SetActive(false);
            //복셀을 오브젝트 풀에 담고 싶다.
            voxelPool.Add(voxel);
        }

    }

    // Update is called once per frame
    void Update()
    {
        //크로스헤어 그리기
        ARAVRInput.DrawCrosshair(crosshair);
        //VR 컨트롤러의 발사 버튼을 누르면
        if (ARAVRInput.Get(ARAVRInput.Button.One))
        {
            currentTime += Time.deltaTime;
            if (currentTime > createTime)
            {
                //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                //컨트롤러가 향하는 방향으로 시선 만들기
                Ray ray = new Ray(ARAVRInput.RHandPosition, ARAVRInput.RHandDirection);

                RaycastHit hitInfo = new RaycastHit();
                if (Physics.Raycast(ray, out hitInfo))
                {
                    //복셀 오브젝트 풀 이용하기
                    //만약 오브젝트 풀에 복셀이 있다면
                    if (voxelPool.Count > 0)
                    {
                        currentTime = 0;
                        //오브젝트 풀에서 복셀을 하나 가져온다
                        GameObject voxel = voxelPool[0];
                        //복셀을 활성화한다
                        voxel.SetActive(true);
                        //복셀을 배치하고 싶다.
                        voxel.transform.position = hitInfo.point;
                        //오브젝트 풀에서 복셀을 제거한다
                        voxelPool.RemoveAt(0);
                    }

                }

            }
        }
    }
}