using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeEffect : MonoBehaviour
{
    private Image image; // fade 효과에 사용하는 바탕 이미지. 
    private void Awake(){
        image = GetComponent<Image>();
    }
    // 알파 a값이 0보다 크면 알파값이 감소.
    private void Update() {
        Color color  = image.color;

        if(color.a > 0)
        {
            color.a -= Time.deltaTime;
        }
        //바뀐 색상 정보를 image.color에 저장.
        image.color = color;
    }
}   
