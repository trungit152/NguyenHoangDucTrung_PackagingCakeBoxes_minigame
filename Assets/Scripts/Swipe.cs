using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GG.Infrastructure.Utils.Swipe;
using Unity.VisualScripting;

public class Swipe : MonoBehaviour
{
    [SerializeField] private SwipeListener swipeListener;
    [SerializeField] private Transform objectTransform;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;
    private bool canMove = true;

    private Vector2 objectDirection = Vector2.zero;
    void Start()
    {
    }
    private void OnEnable()
    {
        swipeListener.OnSwipe.AddListener(OnSwipe);
    }
    private void OnSwipe(string swipe)
    {
        switch (swipe)
        {
            case "Left":
                objectDirection = Vector2.left;
                break;
            case "Right":
                objectDirection = Vector2.right;
                break;
            case "Up":
                objectDirection = Vector2.up;
                break;
            case "Down":
                objectDirection = Vector2.down;
                break;
        }
    }
    private void OnDisable()
    {
        swipeListener.OnSwipe.RemoveListener(OnSwipe);
    }
    public void FixedUpdate()
    {
        if (objectTransform != null)
        {
            objectTransform.position += (Vector3)objectDirection * speed * Time.deltaTime;
        }
    }
}
