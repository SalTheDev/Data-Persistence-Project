using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public string playerName;
    public TMP_InputField inputField;
    public TMP_Text HighScore;

    //Start is called from the first frame update
    void Start()
    {
        WinnerList.Instance.LoadWinnerData();
        HighScore.text = "Best Score: " + WinnerList.Instance.bestPlayer + ": " + WinnerList.Instance.bestScore;
    }

    //Update is called once per frame
    void Update()
    {
        //potential fix, remove if doesnt work
        SaveName();
    }

    public void SaveName()
    {
        playerName = inputField.text;
        WinnerList.Instance.playerName = playerName;
    }

    //Load a Scene: Main Game
    public void LoadScene()
    {
        SceneManager.LoadScene("Scenes/main");
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
       Application.Quit();
#endif
    }

}
