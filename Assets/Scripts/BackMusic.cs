using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackMusic : MonoBehaviour
{
    public AudioSource backMusic;

    void Start()
    {
        DontDestroyOnLoad(backMusic);
        backMusic.Play();
    }

}
