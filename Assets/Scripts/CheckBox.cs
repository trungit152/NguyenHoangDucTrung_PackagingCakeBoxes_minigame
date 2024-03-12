using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckBox : MonoBehaviour
{
    [SerializeField] private GameObject cake;
    [SerializeField] private GameObject winImage;
    void Start()
    {
        winImage.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("CheckBox"))
        {
            Destroy(cake);
            winImage.SetActive(true);
        }
    }
}
