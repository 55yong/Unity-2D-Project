using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scoreObj;
    private int score;

    private void Start()
    {
        score = 0;

        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    public void AddScore()
    {
        score += 1;
        scoreObj.text = "Score : " + score.ToString();
    }

    public int GetScore()
    {
        return score;
    }
}
