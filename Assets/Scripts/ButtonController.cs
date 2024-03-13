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
        //if (char.IsDigit(levelName[levelName.Length] - 1);
        //{
        //    Debug.Log("Chuỗi '" + "' là một số nguyên.");
        //}
        nextLevelNumber = int.Parse(levelName[levelName.Length - 1].ToString()) + 1;
        nextLevelName = levelName.Substring(0, levelName.Length - 1) + nextLevelNumber.ToString();
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
    public void NextLevelClick()
    {
        SceneManager.LoadScene(nextLevelName);
    }
}
