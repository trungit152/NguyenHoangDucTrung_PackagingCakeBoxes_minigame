using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public Object player;
    public Transform parentObject;
    private Vector2 startPos;
    public int pixelDistToDetect = 20;
    private bool fingerDown;

    void Start()
    {
        Vector3 parentCenter = parentObject.position;
        transform.position = parentCenter;
    }

    void Update()
    {
       if(!fingerDown && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            startPos = Input.touches[0].position;
            fingerDown = true;
        }
        if (fingerDown)
        {
            if (Input.touches[0].position.y >= startPos.y + pixelDistToDetect)
            {
                fingerDown = false;
                Debug.Log("Swipe up");
            }
            else if (Input.touches[0].position.x >= startPos.y - pixelDistToDetect)
            {
                fingerDown = false;
                Debug.Log("Swipe down");
            }
            else if (Input.touches[0].position.x <= startPos.x - pixelDistToDetect)
            {
                fingerDown = false;
                Debug.Log("Swipe left");
            }
            else if (Input.touches[0].position.x >= startPos.x - pixelDistToDetect)
            {
                fingerDown = false;
                Debug.Log("Swipe right");
            }
        }
        if(fingerDown && Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Ended)
        {
            fingerDown = false;
        }
        //TESTING FOR PC
        if(!fingerDown && Input.GetMouseButtonDown(0))
        {
            startPos = Input.mousePosition;
            fingerDown = true;
        }
        if(fingerDown)
        {
            if (Input.mousePosition.y >= startPos.y + pixelDistToDetect)
            {
                fingerDown = false;
                Debug.Log("Swipe up");
            }
        }
        if(fingerDown && Input.GetMouseButtonUp(0))
        {
            fingerDown = false;
        }
    }
}
