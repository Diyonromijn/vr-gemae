using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour
{
    public float timerDuration = 60f;
    private float currentTime;

    public TextMeshPro timerText;

    void Start()
    {
        currentTime = timerDuration;
    }

    void Update()
    {
        if (currentTime > 0)
        {
            currentTime -= Time.deltaTime;

            timerText.text = Mathf.Ceil(currentTime).ToString();
        }
        else
        {
            currentTime = 0;
            timerText.text = "0";
            GameOver();
        }
    }

    void GameOver()
    {
        SceneManager.LoadScene("Over");
        timerDuration = 60f;

    }
}

