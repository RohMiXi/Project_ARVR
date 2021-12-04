// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;


// // public enum FadeState{FadeIn = 0, FadeOut, FadeInOut, FadeLoop}
// public class FadeEffect : MonoBehaviour
// {
//     [SerializeField]
//     [Range(0.01f, 10f)]
//     private float fadeTime;
//     [SerializeField]
//     private AnimationCurve fadeCurve;
//     private Image image; // fade 효과에 사용하는 바탕 이미지.
//     private FadeState fadeState; 
//     private void Awake(){
//          image = GetComponent<Image>();

//         // Fade In. 배경의 알파값이 1 -> 0 으로 화면이 점점 밝아짐.
//         //  StartCoroutine(Fade(1,0));
//         // Fade out. 배경의 알파값이 0 -> 1 으로 화면이 점점 어두워짐.
//         StartCoroutine(Fade(0,1));

//         // fade(1,0) 으로 할 경우에는 fade in 
//         // OnFade(FadeState.FadeOut);
//     }
//     private void Update() {
//     {
//         Color color = image.color;

//         if(color.a < 1)
//         {
//             color.a += Time.deltaTime;
//         }
//         image.color = color;
//     }
//     }


//     // 알파 a값이 0보다 크면 알파값이 감소.

//     // public void OnFade(FadeState state)
//     // {
//     //     fadeState = state;
//     //     switch (fadeState)
//     //     {
//     //         case FadeState.FadeIn:
//     //             StartCoroutine(Fade(1,0));
//     //             break;
//     //         case FadeState.FadeOut:
//     //             StartCoroutine(Fade(0,1));
//     //             break;
//     //         case FadeState.FadeInOut: //Fade 효과를 In -> Out 1회 반복한다. 
//     //         case FadeState.FadeLoop: // Fade 효과를 In -> Out 무한 반복한다. 
//     //             StartCoroutine(FadeInOut());
//     //             break;
//     //     }
//     // }
    
    
//     // ----------------------------------------------------------------------------------------//
//     // FadeInOut 반복할 시 필요한 코드

//     // private IEnumerator FadeInOut()
//     // {
//     //     while(true)
//     //     {
//     //         // Coroutine 내부에서 함수를 호출하면, 해당 Coroutine함수가 종료될시, 다음 함수가 빌드됨. 
//     //         yield return StartCoroutine(Fade(1,0));
//     //         yield return StartCoroutine(Fade(0,1));

//     //         // FadeInout이 1회만 재생될 떄, break;
//     //         if(fadeState == FadeState.FadeInOut)
//     //         {
//     //             break;
//     //         }
//     //     }
//     // }

//     // ------------------------------------------------------------------------------------ // 
//     // 현재 시간에 맞춰서 Curve를 주어 시간의 흐름에 따라 FadeInOut을 조절할 수 있는 코드 
//     private IEnumerator Fade(float start, float end) 
//     {
//         float currentTime = 0.0f;
//         float percent = 0.0f;

//         while(percent < 1){
//         // fadeTime으로 나누어서 fadeTime 시간 동안 
//         // precent 값이 0에서 1로 증가하도록 함. 
//         currentTime += Time.deltaTime;
//         percent =  currentTime / fadeTime;

//         // 알파값을 start부터 end까지 fadeTime 시간 동안 변화시킴. 
//         Color color = image.color;
//         color.a = Mathf.Lerp(start, end, fadeCurve.Evaluate(percent));
//         image.color = color;

//         yield return null;
//         }
//     }
// }