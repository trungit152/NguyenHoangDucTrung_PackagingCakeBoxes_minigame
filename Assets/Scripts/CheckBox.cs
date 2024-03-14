using UnityEngine;
using UnityEngine.SceneManagement;
public class CheckBox : MonoBehaviour
{
    [SerializeField] private GameObject cake;
    //[SerializeField] private GameObject winImage;
    void Start()
    {
        //winImage.SetActive(false);
    }
    private void Update()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("CheckBox"))
        {
            Destroy(cake);
        }
    }

}
