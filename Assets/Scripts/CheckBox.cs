using UnityEngine;
using UnityEngine.SceneManagement;
public class CheckBox : MonoBehaviour
{
    [SerializeField] private GameObject cake;
    void Start()
    {
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
