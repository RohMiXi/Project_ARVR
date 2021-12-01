using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCreater : MonoBehaviour
{
    [SerializeField] private float animationDuration = 5f;
    public LineRenderer lineRenderer;
    private void Start(){
        lineRenderer = GetComponent<LineRenderer>();

        StartCoroutine(AnimateLine());
    }
    public IEnumerator AnimateLine()
    {
        float startTime = Time.time;
        Vector3 startPosition = lineRenderer.GetPosition(0);
        Vector3 endPosition = lineRenderer.GetPosition(1);
        Vector3 pos = startPosition;
        while(pos != endPosition){
            float t = (Time.time - startTime) / animationDuration;
            pos = Vector3.Lerp(startPosition, endPosition, t);
            lineRenderer.SetPosition(1, pos);
            yield return null;
        }
    }
    // Start is called before the first frame update

}
