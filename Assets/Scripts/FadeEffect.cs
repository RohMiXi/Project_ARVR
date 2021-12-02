using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeEffect : MonoBehaviour
{
    [SerializeField]
    [Range(0.01f, 10f)]
    private float fadeTime;
    private Image image; // fade 효과에 사용하는 바탕 이미지. 
    private void Awake(){
         image = GetComponent<Image>();
        // fade(1,0) 으로 할 경우에는 fade in 
         StartCoroutine(Fade(1,0)); //fade(0,1)로 할 경우, fade out 효과 
    }
    // 알파 a값이 0보다 크면 알파값이 감소.
    private IEnumerator Fade(float start, float end) 
    {
        float currentTime = 0.0f;
        float percent = 0.0f;

        while(percent < 1){
        // fadeTime으로 나누어서 fadeTime 시간 동안 
        // precent 값이 0에서 1로 증가하도록 함. 
        currentTime += Time.deltaTime;
        percent =  currentTime / fadeTime;

        // 알파값을 start부터 end까지 fadeTime 시간 동안 변화시킴. 
        Color color = image.color;
        color.a = Mathf.Lerp(start, end, percent);
        image.color = color;

        yield return null;
        }
    }
}   
