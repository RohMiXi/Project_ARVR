using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameObject gameOverText;
    [SerializeField] float maxTime = 5f;
    float timeLeft;
    Image timerBar;


    // Update is called once per frame
    void Start()
    {
        gameOverText.SetActive(false);
        timerBar = GetComponent<Image>();
        timeLeft = maxTime;
    }


    void Update() 
    {
        if(timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timerBar.fillAmount = timeLeft / maxTime;
        }
        else{
            gameOverText.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
