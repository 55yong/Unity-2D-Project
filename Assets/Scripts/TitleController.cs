using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TitleController : MonoBehaviour
{
    public Button startBtn;
    public Button infoBtn;
    public Button keyInfoBtn;
    public Button exitBtn;
    public Button showInfoBtn;
    public Button showKeyInfoBtn;

    public GameObject TitleObj;
    public GameObject InfoObj;
    public GameObject KeyInfoObj;

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

        keyInfoBtn.onClick.AddListener(() =>
        {
            TitleObj.SetActive(false);
            KeyInfoObj.SetActive(true);
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

        #region KeyInfoObject
        showKeyInfoBtn.onClick.AddListener(() =>
        {
            KeyInfoObj.SetActive(false);
            TitleObj.SetActive(true);
        });
        #endregion
    }
}
