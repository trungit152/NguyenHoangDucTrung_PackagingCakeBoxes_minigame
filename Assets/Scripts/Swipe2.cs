using TMPro;
using UnityEngine;

public class SwipeDetectionMouse : MonoBehaviour
{
    [SerializeField] private Objects myObject;
    [SerializeField] private GameObject checkBox;

    private Vector3 targetPos;
    private Vector2 fingerDownPosition;
    private Vector2 fingerUpPosition;
    private bool detectSwipe = false;
    private float moveSpeed = 6f;
    private bool isMoving = false;

    private Vector2 mouseDownPositionMouse;
    private Vector2 mouseUpPositionMouse;
    private bool detectSwipeMouse = false;

    private void Start()
    {
        targetPos = myObject.transform.position;
    }
    void Update()
    {
        SwipeMouse();
        Swipe();

        if (myObject.transform.position != targetPos)
        {
            isMoving = true;
        }
        else isMoving = false;

        MoveToTarget(targetPos);
    }
    void MoveToTarget(Vector3 targetPosition)
    {
        Vector3 direction = targetPosition - transform.position;
        float distanceToTarget = direction.magnitude;

        if (distanceToTarget > 0.1f)
        {
            transform.Translate(direction.normalized * moveSpeed * Time.deltaTime);
        }
        else
        {
            myObject.transform.position = targetPos;
        }
    }
    void DetectSwipeDirection()
    {
        float deltaX = fingerUpPosition.x - fingerDownPosition.x;
        float deltaY = fingerUpPosition.y - fingerDownPosition.y;

        if (Mathf.Abs(deltaX) > Mathf.Abs(deltaY))
        {
            // Vuốt ngang
            if (deltaX > 0 && !isMoving)
            {
                checkBox.SetActive(false);
                if (myObject.canMoveRightLong)
                {
                    targetPos = myObject.transform.position + new Vector3(2, 0, 0);
                }
                else if (!myObject.canMoveRightLong && myObject.canMoveRightShort)
                {
                    targetPos = myObject.transform.position + new Vector3(1, 0, 0);
                }
                else if (!myObject.canMoveRightShort)
                {
                    targetPos = myObject.transform.position;
                }
            }
                
            else if (deltaX < 0 && !isMoving)
            {
                checkBox.SetActive(false);
                if (myObject.canMoveLeftLong)
                {
                    targetPos = myObject.transform.position + new Vector3(-2, 0, 0);
                }
                else if (!myObject.canMoveLeftLong && myObject.canMoveLeftShort)
                {
                    targetPos = myObject.transform.position + new Vector3(-1, 0, 0);
                }
                else if (!myObject.canMoveLeftShort)
                {
                    targetPos = myObject.transform.position;
                }
            }
               
        }
        else
        {
            // Vuốt dọc
            if (deltaY > 0 && !isMoving)
            {
                checkBox.SetActive(true);
                if (myObject.canMoveUpLong)
                {
                    targetPos = myObject.transform.position + new Vector3(0, 2, 0);
                }
                else if (!myObject.canMoveUpLong && myObject.canMoveUpShort)
                {
                    targetPos = myObject.transform.position + new Vector3(0, 1, 0);
                }
                else if (!myObject.canMoveUpShort)
                {
                    targetPos = myObject.transform.position;
                }
            }
            else if (deltaY < 0 && !isMoving)
            {
                checkBox.SetActive(true);
                if (myObject.canMoveDownLong)
                {
                    targetPos = myObject.transform.position + new Vector3(0, -2, 0);
                }
                else if (!myObject.canMoveDownLong && myObject.canMoveDownShort)
                {
                    targetPos = myObject.transform.position + new Vector3(0, -1, 0);
                }
                else if (!myObject.canMoveDownShort)
                {
                    targetPos = myObject.transform.position;
                }
            }
        }

        detectSwipe = false;
    }

    void Swipe()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                fingerDownPosition = touch.position;
                detectSwipe = true;
            }

            if (touch.phase == TouchPhase.Ended && detectSwipe)
            {
                fingerUpPosition = touch.position;
                DetectSwipeDirection();
            }
        }
    }


    //mouseTest

    private void SwipeMouse()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mouseDownPositionMouse = Input.mousePosition;
            detectSwipeMouse = true;
        }

        if (Input.GetMouseButtonUp(0) && detectSwipeMouse)
        {
            mouseUpPositionMouse = Input.mousePosition;
            DetectSwipeDirectionMouse();
        }
    }

    void DetectSwipeDirectionMouse()
    {
        float deltaX = mouseUpPositionMouse.x - mouseDownPositionMouse.x;
        float deltaY = mouseUpPositionMouse.y - mouseDownPositionMouse.y;

        if (Mathf.Abs(deltaX) > Mathf.Abs(deltaY))
        {
            // Vuốt ngang
            if (deltaX > 0 && !isMoving)
            {
                checkBox.SetActive(false);
                if (myObject.canMoveRightLong)
                {
                    targetPos = myObject.transform.position + new Vector3(2, 0, 0);
                }
                else if(!myObject.canMoveRightLong && myObject.canMoveRightShort)
                {
                    targetPos = myObject.transform.position + new Vector3(1, 0, 0);
                }
                else if (!myObject.canMoveRightShort)
                {
                    targetPos = myObject.transform.position;
                }
            }
                
            else if (deltaX < 0 && !isMoving)
            {
                checkBox.SetActive(false);
                Debug.Log("Vuốt sang trái");
                if (myObject.canMoveLeftLong)
                {
                    targetPos = myObject.transform.position + new Vector3(-2, 0, 0);
                }
                else if (!myObject.canMoveLeftLong && myObject.canMoveLeftShort)
                {
                    targetPos = myObject.transform.position + new Vector3(-1, 0, 0);
                }
                else if (!myObject.canMoveLeftShort)
                {
                    targetPos = myObject.transform.position;
                }
            }
                
        }
        else
        {
            // Vuốt dọc
            if (deltaY > 0 && !isMoving)
            {
                checkBox.SetActive(true);
                if (myObject.canMoveUpLong)
                {
                    targetPos = myObject.transform.position + new Vector3(0, 2, 0);
                }
                else if (!myObject.canMoveUpLong && myObject.canMoveUpShort)
                {
                    targetPos = myObject.transform.position + new Vector3(0, 1, 0);
                }
                else if (!myObject.canMoveUpShort)
                {
                    targetPos = myObject.transform.position;
                }
            }
            else if (deltaY < 0 && !isMoving)
            {
                Debug.Log("Vuốt xuống dưới");
                checkBox.SetActive(true);
                if (myObject.canMoveDownLong)
                {
                    targetPos = myObject.transform.position + new Vector3(0, -2, 0);
                }
                else if (!myObject.canMoveDownLong && myObject.canMoveDownShort)
                {
                    targetPos = myObject.transform.position + new Vector3(0, -1, 0);
                }
                else if (!myObject.canMoveDownShort)
                {
                    targetPos = myObject.transform.position;
                }
            }
                
        }

        detectSwipeMouse = false;
    }
}
