using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using StarterAssets;

public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    public ThirdPersonController thirdPersonController;
    public StarterAssetsInputs starterAssetsInputs;
    public bool ping;

    void Update () {
           if (Input.GetKeyDown (KeyCode.Escape))
           {
                if (GameIsPaused)
                {
                    Resume();
                } else
                {
                    Pause();
                }
           }
    }
    void Start ()
    {
        starterAssetsInputs.cursorLocked = true;
        Cursor.visible = false;
    }
    public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        thirdPersonController.LockCameraPosition = false;
        starterAssetsInputs.cursorLocked = true;
        Cursor.visible = false;
    }
    void Pause ()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        thirdPersonController.LockCameraPosition = true;
        starterAssetsInputs.cursorLocked = false;
        Cursor.visible = true;  
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }
    public void QuitGame()
    {
        Debug.Log ("Quitting gmae....");
        Application.Quit();
    }

}
