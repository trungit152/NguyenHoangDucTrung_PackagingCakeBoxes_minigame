using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour
{
    public AudioSource clickSound;
    public void StartClick()
    {
        clickSound.Play();
        SceneManager.LoadScene("SeclectLevel");
    }
}
