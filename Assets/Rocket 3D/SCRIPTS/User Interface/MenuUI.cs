using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    private GameObject mainMenu;
    private GameObject levelsMenu;
    private GameObject settingsMenu;
    private GameObject confirmationMenu;

    private Slider soundsSlider;
    private Slider cameraView;



    private void Start()
    {
        GameObject menuUI = GameObject.FindGameObjectWithTag("Menu UI");

        mainMenu = menuUI.transform.Find("Main Menu").gameObject;
        levelsMenu = menuUI.transform.Find("Levels Menu").gameObject;
        settingsMenu = menuUI.transform.Find("Settings Menu").gameObject;
        confirmationMenu = menuUI.transform.Find("Confirmation Menu").gameObject;

        soundsSlider = settingsMenu.transform.Find("Sounds Slider").gameObject.GetComponent<Slider>();
        cameraView = settingsMenu.transform.Find("Camera Slider").gameObject.GetComponent<Slider>();
    }

    #region Levels Menu
    public void OnClick_OpenLevelsMenu()
    {
        mainMenu.SetActive(false);
        levelsMenu.SetActive(true);
    }

    public void OnClick_LoadLevel(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex);
    }

    public void OnClick_CloseLevelsMenu()
    {
        levelsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
    #endregion

    #region Settings Menu
    public void OnClick_OpenSettingsMenu()
    {
        mainMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }

    public void OnClick_CloseSettingsMenu()
    {
        settingsMenu.SetActive(false);
        mainMenu.SetActive(true);
    }

    public void OnClick_OpneResetProgressMenu()
    {
        settingsMenu.SetActive(false);
        confirmationMenu.SetActive(true);
    }

    public void OnClick_ResetProgress_NO()
    {
        confirmationMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }

    public void OnClick_ResetProgress_YES()
    {
        confirmationMenu.SetActive(false);
        settingsMenu.SetActive(true);
    }
    #endregion

    #region Review
    public void OnClick_Review()
    {
        
    }
    #endregion
}
