using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
}
