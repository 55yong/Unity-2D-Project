using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    GameObject gm;

    public Text text;

    private void Awake()
    {
        gm = GameObject.Find("GameManager");
        text.text = "최종 점수 : " + gm.gameObject.GetComponent<GameManager>().GetScore().ToString();
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene("TitleScene");
        }
        if(Input.GetKey(KeyCode.Escape))
        {
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif
        }
    }
}
