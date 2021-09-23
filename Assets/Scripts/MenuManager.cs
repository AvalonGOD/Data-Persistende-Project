using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuManager : MonoBehaviour
{
    public InputField InputField;
    public Text menuBestScore;
    

    private void Start()
    {
        menuBestScore.text = SaveScore.Instance.bestScore;
        
    }
    public void StartGame()
    {

        
        SaveScore.Instance.ChangeBestScoteText();
        
        SceneManager.LoadScene(1);
    }

    public void ResetScore()
    {
        SaveScore.Instance.score = 0;
        menuBestScore.text = "Best Score: ";
    }

    public void SetName()
    {
        SaveScore.Instance.name = InputField.text;
    }

    public void ExitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
