using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class GameControl : MonoBehaviour
{
    public static int Score;
    public static float Health;

    public Text KillEnemy;
    public Image HealthBar;

    public GameObject GameOver;
    void Start()
    {
        GameOver.SetActive(false);
        Health = 1;
        Score = 0;
    }
    void Update()
    {
        HealthBar.fillAmount = Health;
        KillEnemy.text = Score.ToString();
        if (Health <= 0)
        {
            GameOver.SetActive(true);
            Time.timeScale = 0;
        }
    }
    public void Restart()
    {
        Time.timeScale = 1;
        Health = 1;
        Score = 0;
        GameOver.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
