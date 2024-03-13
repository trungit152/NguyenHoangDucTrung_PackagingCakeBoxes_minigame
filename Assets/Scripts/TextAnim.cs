using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAnim : MonoBehaviour
{
    [SerializeField] private Text guideText;
    void Start()
    {
        
    }

    public void ShowText()
    {
        guideText.enabled = true;
    }
    public void HideText()
    {
        guideText.enabled = false;
    }
}
