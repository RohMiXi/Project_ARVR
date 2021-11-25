using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] _myPanel;
    public GameObject Information;
    public void OpenPanel(int num)
    {
        //_myPanel = GameObject.FindGameObjectWithTag("Information");
        if(_myPanel != null)
        {
            _myPanel[num].SetActive(true);
        }
    }
}
 