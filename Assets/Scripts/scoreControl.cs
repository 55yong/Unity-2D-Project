using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreControl : MonoBehaviour
{
    GameObject scoreObj;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreObj = GameObject.Find ("Score");
    }

    // Update is called once per frame
    public void AddScore()
    {
        score += 10;
        scoreObj.GetComponent<Text> ().text = score.ToString ();
    }
}
