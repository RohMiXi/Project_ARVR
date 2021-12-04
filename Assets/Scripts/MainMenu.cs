using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public GameObject Panel;
    // Start is called before the first frame update
    public GameObject[] _myPanel; // 배열로 받아서 입력값을 줌. 
    //public GameObject[] _closePanel;
    public GameObject Information;
    public void OpenPanel() // 배열에 들어갈 변수 값을 입력 
    {
         if(Panel != null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }
    }
    // public void ClosePanel(int num)
    // {
    //     if(_closePanel != null)
    //     {
    //         _closePanel[num].SetActive(true);
    //     }
    // }
}
 