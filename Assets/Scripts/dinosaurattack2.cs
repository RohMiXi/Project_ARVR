using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class dinosaurattack2 : MonoBehaviour
{
    public GameObject Cubefactory;
    public int cubePoolSize = 5;
    public static List<GameObject> cubePool = new List<GameObject>();
    Transform XRRig;
    public float attackRange = 10;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < cubePoolSize; i++)
        {
            GameObject CubeCube = Instantiate(Cubefactory);
            CubeCube.SetActive(false);
            cubePool.Add(CubeCube);
        }
        XRRig = GameObject.Find("XR Rig").transform;
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Vector3 dir = transform.TransformDirection(-100f, -10f, 0f);
        Debug.DrawRay(transform.position, dir, Color.red);
        if (Vector3.Distance(transform.position, XRRig.position) < attackRange)
        {
            if (Physics.Raycast(transform.position, dir, out hit))
            {
                if (cubePool.Count > 0)
                {
                    GameObject CubeCube = cubePool[0];
                    CubeCube.SetActive(true);
                    CubeCube.transform.position = hit.point;
                    cubePool.RemoveAt(0);
                }

            }
        }
    }
}
