using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{

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
    public void NextLevelClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SelectLevel");
    }
}
