using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class BtnInteration : MonoBehaviour
{
    // Start is called before the first frame update
    public void scenechanger(){
        SceneManager.LoadScene("Ending_Scene");
    }
    public void SceneChange(){
        SceneManager.LoadScene("MoveToEnding");
    }
}