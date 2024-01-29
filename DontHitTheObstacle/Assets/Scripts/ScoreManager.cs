using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int Score { get; private set; }
    private int highScore;
    public Text scoreText;
    public Text highScoreText;
    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        highScore = PlayerPrefs.GetInt("highScore", 0);
        UpdateSkorText();
        UpdateHighScoreText();
    }
    public void scoreArttýr(int artýsMiktari)
    {
        Score += artýsMiktari;
            UpdateSkorText();
        if (Score > highScore)
        {
            highScore = Score;
            PlayerPrefs.SetInt("highScore", highScore);
            UpdateHighScoreText();   

        }
    }

    // Update is called once per frame
    void UpdateSkorText()
    {
        scoreText.text = "Score: " + Score;
    }
    void UpdateHighScoreText()
    {
        
            highScoreText.text = "highScore: " + highScore;
    }
}
