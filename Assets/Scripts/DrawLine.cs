using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    public GameObject linePrefab;
    LineRenderer lr; // 라인을 그려주는 컴퍼넌트 'lr'추가 
    EdgeCollider2D collider2D; // 라인에 적용되는 충돌체 적용 
    List<Vector2> points = new List<Vector2>(); // 3d environmnent to draw a sign in panel.
    void Update() {
        if(input.GetMouseButtonDown(0))
        {   
            GameObject go = Instantiate(linePrefab); // 라인을 연속적으로 그릴 수 있도록 복제 Instantiate 사용
            lr = go.GetComponent<LineRenderer>(); // 라인 컴퍼넌트를 go 라는 오브젝트에 가져와서 lr에 저장. 
            col = go.GetComponent<EdgeCollider2D>(); // collider 2D 값에 라인에 적용되는 충돌 여부를 체크. 
            points.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition));
            lr.positionCount = 1; // 라인이 그려질 때의 값. 
            lr.SetPosition(0, points[0]); //마우스의 시작점에서 list로 선언한 point[] 부분으로 이동 
        }else if(Input.GetMouseButton(0))
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(Vector2.Distance(points[points.Count - 1], pos) > 0.1f) 
            {
                points.Add(pos);
                lr.positionCount++;
                lr.SetPosition(lr.positionCount-1, pos);
                col.points = points.ToArray();
            }
        }else if(Input.GetMouseButtonUp(0))
        {
            points.Clear();
        }
    }
}
