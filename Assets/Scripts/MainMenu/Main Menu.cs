using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); // ngeload sample scene
    }
    public void GoToSettingsMenu()
    {
        SceneManager.LoadScene("OptionMenu");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
            }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
