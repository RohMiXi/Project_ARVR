using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] _myPanel; // 배열로 받아서 입력값을 줌. 
    //public GameObject[] _closePanel;
    public GameObject Information;
    public void OpenPanel(int num) // 배열에 들어갈 변수 값을 입력 
    {
        //_myPanel = GameObject.FindGameObjectWithTag("Information");
        for(int i = 0; i < _myPanel.Length ; i++){ //_myPanel.Length를 넣어준 이유는, text 문자 수의 값을 할당해서 열리도록 하기 위해서
            _myPanel[i].SetActive(false); 
        }
        _myPanel[num].SetActive(true);
    }
    // public void ClosePanel(int num)
    // {
    //     if(_closePanel != null)
    //     {
    //         _closePanel[num].SetActive(true);
    //     }
    // }
}
 