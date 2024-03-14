using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Windows;

public class ButtonController : MonoBehaviour
{
    private string levelName;
    int nextLevelNumber;
    private void Start()
    {
        levelName = SceneManager.GetActiveScene().name;
        char test = levelName[levelName.Length - 1];
    }
    public void HomeClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("StartMenu");
    }
    public void ResetClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void PlayClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SelectLevel");
    }
    //private bool SceneExists(string sceneName)
    //{
    //    for (int i = 0; i < SceneManager.sceneCount; i++)
    //    {
    //        Scene scene = SceneManager.GetSceneAt(i);
    //        if (scene.name == sceneName)
    //        {
    //            return true;
    //        }
    //    }
    //    return false;
    //}
    public void NextLevelClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SelectLevel");
    }
}
