using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyManager : MonoBehaviour
{
    public GameObject KeyBoard;
    public Text m_InputField;

    public bool KeyEditDone = false;
    public bool TextDone = false;

    // Start is called before the first frame update
    void Start()
    {

    }
    public void iptOnClick()
    {
        m_InputField.text = "";
        TextDone = !TextDone;
    }

    // Update is called once per frame
    void Update()
    {
        if (TextDone)
        {
            KeyBoard.SetActive(true);
        }
        else
        {
            KeyBoard.SetActive(false);
            if (KeyEditDone)
            {
                KeyEditDone = false;
            }
        }
    }
}
