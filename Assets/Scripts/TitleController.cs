using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleController : MonoBehaviour
{
    public Button startBtn;
    public Button infoBtn;
    public Button exitBtn;
    public Button showInfoBtn;

    public GameObject TitleObj;
    public GameObject InfoObj;

    private void Awake()
    {
        TitleObj.SetActive(true);
        InfoObj.SetActive(false);
    }

    private void Start()
    {
        #region TitleObject
        startBtn.onClick.AddListener(() =>
        {
            SceneManager.LoadScene("GameScene");
        });

        infoBtn.onClick.AddListener(() =>
        {
            TitleObj.SetActive(false);
            InfoObj.SetActive(true);
        });

        exitBtn.onClick.AddListener(() =>
        {
            #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
            #else
                Application.Quit();
            #endif
        });
        #endregion

        #region InfoObject
        showInfoBtn.onClick.AddListener(() =>
        {
            InfoObj.SetActive(false);
            TitleObj.SetActive(true);
        });
        #endregion
    }
}
