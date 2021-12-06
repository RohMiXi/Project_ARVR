using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class xrrigdamage : MonoBehaviour
{
    public Transform damageUI;
    public Image damageimage;
    public float damageTime = 0.1f;
    Transform XRRig;
    public float attackRange = 10;
    public bool inthefire;

    IEnumerator DamageEvent()
    {
        damageimage.enabled = true;
        yield return new WaitForSeconds(damageTime);
        damageimage.enabled = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        float z = Camera.main.nearClipPlane + 0.01f;
        damageUI.parent = Camera.main.transform;
        damageUI.localPosition = new Vector3(0, 0, z);
        damageimage.enabled = false;
        XRRig = GameObject.Find("XR Rig").transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, XRRig.position) < attackRange)
        {
            StopAllCoroutines();
            StartCoroutine(DamageEvent());
            inthefire = true;

        }
        else
        {
            inthefire = false;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Ãæµ¹");
    }


}
