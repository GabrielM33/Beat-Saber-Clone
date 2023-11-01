using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreCounterScript : MonoBehaviour
{
    public TMPro.TextMeshProUGUI ScoreText;    public int score = 0;
    public int maxScore;

    void Start()
    {
        score = 0;
    }

    public void AddScore(int newScore) 
    {
        score += newScore;
    }

    public void UpdateScore() 
    {
        ScoreText.text = "0" + score;
    }

    void Update()
    {
        UpdateScore();
    }
}
