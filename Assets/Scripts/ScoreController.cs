using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    public Text scoreObj;

    GameObject gm;

    private void Start()
    {
        gm = GameObject.Find("GameManager");
    }

    public void AddScore()
    {
        gm.gameObject.GetComponent<GameManager>().SetScore();
        scoreObj.text = "Score : " + gm.gameObject.GetComponent<GameManager>().GetScore().ToString();
    }
}
