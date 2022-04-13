using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreText : MonoBehaviour
{
    public static ScoreText instance;
    public int points = 0;
    public Text scoreText;
    

    public void Awake()
    {
        instance = this;
    }

    public void Start()
    {
        scoreText.text = points.ToString();
    }

    public void AddPoints()
    {
        points += 1;
        scoreText.text = points.ToString();

        if (points == 20)
        {
            SceneManager.LoadScene(4);
        }
    }



}
