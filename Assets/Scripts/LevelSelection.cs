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
    void Start()
    {
        data = ScriptableObject.CreateInstance<DataOS>();
        thisLevel = int.Parse(this.levelText.text);
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
}
