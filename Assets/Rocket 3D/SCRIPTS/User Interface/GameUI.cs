using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    private GameObject pauseMiniMenu;
    private GameObject pauseButton;
    private GameObject gamePausedText;

    private bool IsInicialized = false;

    private void Init()
    {
        IsInicialized = true;

        GameObject canvas = GameObject.FindGameObjectWithTag("Game UI");
        pauseMiniMenu = canvas.transform.Find("Pause Mini Menu").gameObject;
        pauseButton = canvas.transform.Find("Pause (Button)").gameObject;
        gamePausedText = canvas.transform.Find("Game Paused (Text)").gameObject;
    }

    public void OnClick_PauseGame()
    {
        if (!IsInicialized) { Init(); }

        pauseButton.SetActive(false);
        pauseMiniMenu.SetActive(true);
        gamePausedText.SetActive(true);
    }

    #region Pause Menu
    public void OnClick_GoToMenu()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
    }

    public void OnClick_RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void Onclick_Continue()
    {
        pauseMiniMenu.SetActive(false);
        gamePausedText.SetActive(false);
        pauseButton.SetActive(true);
        Time.timeScale = 1;
    }
    #endregion
}
