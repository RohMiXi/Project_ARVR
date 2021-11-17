using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Panel;


    public void OpenPanel()
    {
        if(Panel !=null)
        {
            bool isActive = Panel.activeSelf;
            Panel.SetActive(!isActive);
        }
    }


    // public void OnClickoptionbtn()
    // {
    //     Debug.Log("옵션");
    // }

    // public void OnClickbackbtn()
    // {
    //     Debug.Log("불러오기");
    // }

}
 