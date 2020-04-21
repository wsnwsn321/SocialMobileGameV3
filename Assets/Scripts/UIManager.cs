using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void LoadScene(string name)
    {
        Application.LoadLevel(name);
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // loads current scene
    }

    public void SaveScene()
    {
        //get name of the scene
        string name = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetString("preScene", name);
    }

    public void ReturnGame()
    {
        SceneManager.LoadScene(PlayerPrefs.GetString("preScene")); // loads prevoius scene
    }

    public void ArchiveClear()
    {
        PlayerPrefs.SetInt("coin", 0);
        PlayerPrefs.SetInt("magnet", 0);
        PlayerPrefs.SetInt("gravity", 0);
        PlayerPrefs.SetInt("shield", 0);
        PlayerPrefs.SetInt("slow", 0);
    }

}
