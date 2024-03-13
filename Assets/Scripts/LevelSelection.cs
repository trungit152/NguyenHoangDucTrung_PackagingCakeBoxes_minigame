using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelection : MonoBehaviour
{
    public DataOS data;
    [SerializeField] private Text levelText;
    [SerializeField] private Image lockImage;
    private int thisLevel;
    private string levelName;
    void Start()
    {
        thisLevel = int.Parse(this.levelText.text);
        levelName = "Level" + thisLevel.ToString();
    }
    void Update()
    {
        if (data.levelUnlocked >= thisLevel) 
        {
            lockImage.enabled = false;
            levelText.enabled = true;
        }
        else if(data.levelUnlocked < thisLevel)
        {
            lockImage.enabled = true;
            levelText.enabled = false;
        }
    }
    public void OnClick()
    {
        SceneManager.LoadScene(levelName);
    }
}
