using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class GameManagerS : MonoBehaviour
{
    int coinColl = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI TimerText;

    public GameObject winPannel;
    public GameObject lossPannel;

    public float timer = 20;

    public void coinAdd()
    {
        coinColl++;
        scoreText.text = "Coin : " + coinColl;
    }

    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            TimeSpan timerData = TimeSpan.FromSeconds(timer);
            TimerText.text = "Timer : " + timerData.Seconds;

            if (coinColl == 6)
            {
                winPannel.SetActive(true);
                Time.timeScale = 0f;
            }

        }
        else
        {

            lossPannel.SetActive(true);
            Time.timeScale = 0.2f;
        }




    }
}