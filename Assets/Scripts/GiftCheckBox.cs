using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GiftCheckBox : MonoBehaviour
{
    [SerializeField] private GameObject winImage;
    public DataOS data;
    public AudioSource winSound;

    private bool playable = false;
    private float cd = 0.3f;
    private string thisLevelName;
    private int thisLevel;
    void Start()
    {
        thisLevelName = SceneManager.GetActiveScene().name;
        char test = thisLevelName[thisLevelName.Length - 1];
        if (char.IsDigit(test))
        {
            thisLevel = int.Parse(thisLevelName[thisLevelName.Length - 1].ToString());
        }
        cd = 0.3f;
        winImage.SetActive(false);
    }
    private void Update()
    {
        if (cd != 0.3f && cd > 0)
        {
            cd -= Time.deltaTime;
        }
        else if (cd <= 0)
        {           
            winImage.SetActive(true);
            Time.timeScale = 0;
        }

        if (playable)
        {
            winSound.Play();
            playable = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cake"))
        {
            cd -= 0.01f;
            playable = true;
            if(data.levelUnlocked == thisLevel)
            {
                data.levelUnlocked++;
            }
        }
    }
}
