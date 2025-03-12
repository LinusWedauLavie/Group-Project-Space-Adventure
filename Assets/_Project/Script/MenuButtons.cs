using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("Cryo");
    }
    public void EndGame()
    {
        Application.Quit();
    }
    public void BackToStart()
    {   
        SceneManager.LoadScene("Menu");
    }
    public void Settings()
    {   
        SceneManager.LoadScene("Settings");
    }
    public void Credits()
    {   
        SceneManager.LoadScene("Credits");
    }
}
