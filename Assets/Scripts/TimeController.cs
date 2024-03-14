using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TimeController : MonoBehaviour
{
    private float time;
    public AudioSource loseSound;
    [SerializeField] private Text timeText;
    [SerializeField] private GameObject LoseImage;

    private void Start()
    {
        LoseImage.SetActive(false);
        time = 45f;
        timeText.text = System.Math.Round(time,0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if(time>0)
        {
            time -= Time.deltaTime;
            timeText.text = System.Math.Round(time, 0).ToString();
        }
        if(time <= 0)
        {
            LoseImage.SetActive(true);
            loseSound.Play();
        }
    }
}
