using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//

public class Menu : MonoBehaviour
{
    public float delay;

    public void OnPlayButton()
    {
        StartCoroutine(LevelLoader());
    }

    public void OnQuitButton()
    {
        Application.Quit();
    }


    private IEnumerator LevelLoader()
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(01);
    }
}
