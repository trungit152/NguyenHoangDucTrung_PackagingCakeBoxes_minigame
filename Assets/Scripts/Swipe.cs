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

    private bool isMoving = false;
    //private Vector2 origPos, targetPos;
    private float timeToMove;
    private Vector2 objectDirection = Vector2.zero;
    private float cd = 0.4f;
    void Start()
    {
        timeToMove = cd;
    }
    private void OnEnable()
    {
        swipeListener.OnSwipe.AddListener(OnSwipe);
    }
    private void OnSwipe(string swipe)
    {
        if (!isMoving)
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
            timeToMove -= 0.01f;
        }
    }
    private void OnDisable()
    {
        swipeListener.OnSwipe.RemoveListener(OnSwipe);
    }
    //private IEnumerator MoveObject(Vector2 direction)
    //{
    //    isMoving = true;

    //    float elapsedTime = 0;

    //    origPos = objectTransform.position;
    //    targetPos = origPos + direction;

    //    while(elapsedTime < timeToMove) 
    //    {
    //        objectTransform.position = Vector2.Lerp(origPos, targetPos, elapsedTime/timeToMove);
    //        elapsedTime += Time.deltaTime;
    //        yield return null;
    //    }
    //    objectTransform.position = targetPos;

    //    isMoving = false;
    //}
    public void FixedUpdate()
    {
        CheckMoving();
        if (objectTransform != null)
        {
            objectTransform.position += (Vector3)objectDirection * speed * Time.deltaTime;
        }
    }
    private void CheckMoving()
    {
        if(timeToMove < 0f)
        {
            timeToMove = cd;
        }
        else if(timeToMove != cd)
        {
            isMoving = true;
        }
        else isMoving = false;

        if(timeToMove != cd)
        {
            timeToMove -= Time.deltaTime;
        }

    }
}
