using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        
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
}
