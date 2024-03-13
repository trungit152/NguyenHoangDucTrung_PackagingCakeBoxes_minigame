using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Windows;

public class ButtonController : MonoBehaviour
{
    private string levelName;
    private string nextLevelName;
    int nextLevelNumber;
    private void Start()
    {
        levelName = SceneManager.GetActiveScene().name;
        char test = levelName[levelName.Length - 1];
        if (char.IsDigit(test))
        {
            nextLevelNumber = int.Parse(levelName[levelName.Length - 1].ToString()) + 1;
            nextLevelName = levelName.Substring(0, levelName.Length - 1) + nextLevelNumber.ToString();
        }
    }
    public void HomeClick()
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void ResetClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void PlayClick()
    {
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
        SceneManager.LoadScene("SelectLevel");
    }
}
