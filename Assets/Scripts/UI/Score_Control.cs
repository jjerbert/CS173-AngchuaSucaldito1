using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score_Control : MonoBehaviour
{
    public Text scoreText;
    public Text timeText;
    public static float time = 0;
    public static int score = 0;
    public GameOverScreen GameOverScreen;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    void Update()
    {
        time += Time.deltaTime;

        if(time >= 2)
        {
            time = 60.00f;
            GameOverScreen.Setup(score);
        }

        scoreText.text = "SCORE: " + score.ToString();
        timeText.text = "TIME: " + time.ToString("F2");
        
    
    }

    public static void AddPoint()
    {
        score++;
    }
    public static void MinusPoint()
    {
        score--;
    }

    public void QuitGame ()
    {
        Debug.Log("QUIT!"); 
        Application.Quit();
    }

    public void MenuScreen()
    {
        Debug.Log("Click");
        SceneManager.LoadScene("MainMenu");
    }
}

