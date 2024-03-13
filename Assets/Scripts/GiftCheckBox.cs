using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GiftCheckBox : MonoBehaviour
{
    [SerializeField] private GameObject checkBox;
    [SerializeField] private GameObject winImage;
    public DataOS data;

    private float cd = 0.6f;
    private string thisLevelName;
    private int thisLevel;
    void Start()
    {
        thisLevelName = SceneManager.GetActiveScene().name;
        thisLevel = int.Parse(thisLevelName[thisLevelName.Length - 1].ToString());
        cd = 0.6f;
        winImage.SetActive(false);
    }
    private void Update()
    {
        if (cd != 0.6f && cd > 0)
        {
            cd -= Time.deltaTime;
        }
        else if (cd <= 0)
        {
            winImage.SetActive(true);
        }   
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cake"))
        {
            cd -= 0.01f;
            if(data.levelUnlocked == thisLevel)
            {
                data.levelUnlocked++;
            }
        }
    }
}
