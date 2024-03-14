using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objects : MonoBehaviour
{
    public float longRaycastDistance = 1.5f;
    public float shortRaycastDistance = 0.5f;
    public LayerMask layerMask;
    //public LayerMask boxLayerMask;
    //public LayerMask cakeLayerMask;

    public bool canMoveLeftLong;
    public bool canMoveLeftShort;
    public bool canMoveRightLong;
    public bool canMoveRightShort;
    public bool canMoveUpShort;
    public bool canMoveUpLong;
    public bool canMoveDownShort;
    public bool canMoveDownLong;

    public Vector2 currentPosition;
    void Update()
    {
        currentPosition = transform.position;
        CheckLongLeft();
        CheckLongRight();
        CheckLongTop();
        CheckLongBottom();
        CheckShortBottom();
        CheckShortLeft();
        CheckShortRight();
        CheckShortTop();

        ////for cake
        //CheckLongLeftBox();
        //CheckShortLeftBox();
        //CheckLongRightBox();
        //CheckShortRightBox();
        //CheckLongTopBox();
        //CheckShortTopBox();

        ////for box
        //CheckLongLeftCake();
        //CheckLongRightCake();
        //CheckLongBottomCake();
        //CheckShortBottomCake();
        //CheckShortLeftCake();
        //CheckShortRightCake();
    }
    public void CheckLongLeft()
    {
        Vector2 raycastDirection = Vector2.left;
        RaycastHit2D hit = Physics2D.Raycast(currentPosition + new Vector2(-0.5f,0), raycastDirection, longRaycastDistance, layerMask);
        if (hit.collider != null && hit.collider.CompareTag("Candy"))
        {
            canMoveLeftLong = false;
        }
        else canMoveLeftLong = true;
    }
    public void CheckShortLeft()
    {
        Vector2 raycastDirection = Vector2.left;
        RaycastHit2D hit = Physics2D.Raycast(currentPosition + new Vector2(-0.5f, 0), raycastDirection, shortRaycastDistance, layerMask);
        if (hit.collider != null && hit.collider.CompareTag("Candy"))
        {
            canMoveLeftShort = false;
        }
        else canMoveLeftShort = true;
    }
    public void CheckShortRight()
    {
        Vector2 raycastDirection = Vector2.right;
        RaycastHit2D hit = Physics2D.Raycast(currentPosition + new Vector2(0.5f, 0), raycastDirection, shortRaycastDistance, layerMask);
        if (hit.collider != null && hit.collider.CompareTag("Candy"))
        {
            canMoveRightShort = false;
        }
        else canMoveRightShort = true;
    }
    public void CheckLongRight()
    {
        Vector2 raycastDirection = Vector2.right;
        RaycastHit2D hit = Physics2D.Raycast(currentPosition + new Vector2(0.5f, 0), raycastDirection, longRaycastDistance, layerMask);
        if (hit.collider != null && hit.collider.CompareTag("Candy"))
        {
            canMoveRightLong = false;
        }
        else canMoveRightLong = true;
    }
    public void CheckLongTop()
    {
        Vector2 raycastDirection = Vector2.up;
        RaycastHit2D hit = Physics2D.Raycast(currentPosition + new Vector2(0, 0.5f), raycastDirection, longRaycastDistance, layerMask);
        if (hit.collider != null && hit.collider.CompareTag("Candy"))
        {
            canMoveUpLong = false;
        }
        else canMoveUpLong = true;
    }
    public void CheckShortTop()
    {
        Vector2 raycastDirection = Vector2.up;
        RaycastHit2D hit = Physics2D.Raycast(currentPosition + new Vector2(0, 0.5f), raycastDirection, shortRaycastDistance, layerMask);
        if (hit.collider != null && hit.collider.CompareTag("Candy"))
        {
            canMoveUpShort = false;
        }
        else canMoveUpShort = true;
    }
    public void CheckShortBottom()
    {
        Vector2 raycastDirection = Vector2.down;
        RaycastHit2D hit = Physics2D.Raycast(currentPosition + new Vector2(0, -0.5f), raycastDirection, shortRaycastDistance, layerMask);
        if (hit.collider != null && hit.collider.CompareTag("Candy"))
        {
            canMoveDownShort = false;
        }
        else canMoveDownShort = true;
    }
    public void CheckLongBottom()
    {
        Vector2 raycastDirection = Vector2.down;
        RaycastHit2D hit = Physics2D.Raycast(currentPosition + new Vector2(0, -0.5f), raycastDirection, longRaycastDistance, layerMask);
        if (hit.collider != null && hit.collider.CompareTag("Candy"))
        {
            canMoveDownLong = false;
        }
        else canMoveDownLong = true;
    }

    ////for box
    //public void CheckLongLeftCake()
    //{
    //    Vector2 raycastDirection = Vector2.left;
    //    RaycastHit2D hit = Physics2D.Raycast(currentPosition + new Vector2(-0.5f, 0), raycastDirection, longRaycastDistance, cakeLayerMask);
    //    if (hit.collider != null && hit.collider.CompareTag("Cake"))
    //    {
    //        canMoveLeftLong = false;
    //    }
    //    else canMoveLeftLong = true;
    //}
    //public void CheckShortLeftCake()
    //{
    //    Vector2 raycastDirection = Vector2.left;
    //    RaycastHit2D hit = Physics2D.Raycast(currentPosition + new Vector2(-0.5f, 0), raycastDirection, shortRaycastDistance, cakeLayerMask);
    //    if (hit.collider != null && hit.collider.CompareTag("Cake"))
    //    {
    //        canMoveLeftShort = false;
    //    }
    //    else canMoveLeftShort = true;
    //}
    //public void CheckShortRightCake()
    //{
    //    Vector2 raycastDirection = Vector2.right;
    //    RaycastHit2D hit = Physics2D.Raycast(currentPosition + new Vector2(0.5f, 0), raycastDirection, shortRaycastDistance, cakeLayerMask);
    //    if (hit.collider != null && hit.collider.CompareTag("Cake"))
    //    {
    //        canMoveRightShort = false;
    //    }
    //    else canMoveRightShort = true;
    //}
    //public void CheckLongRightCake()
    //{
    //    Vector2 raycastDirection = Vector2.right;
    //    RaycastHit2D hit = Physics2D.Raycast(currentPosition + new Vector2(0.5f, 0), raycastDirection, longRaycastDistance, cakeLayerMask);
    //    if (hit.collider != null && hit.collider.CompareTag("Cake"))
    //    {
    //        canMoveRightLong = false;
    //    }
    //    else canMoveRightLong = true;
    //}
    //public void CheckShortBottomCake()
    //{
    //    Vector2 raycastDirection = Vector2.down;
    //    RaycastHit2D hit = Physics2D.Raycast(currentPosition + new Vector2(0, -0.5f), raycastDirection, shortRaycastDistance, cakeLayerMask);
    //    if (hit.collider != null && hit.collider.CompareTag("Cake"))
    //    {
    //        canMoveDownShort = false;
    //    }
    //    else canMoveDownShort = true;
    //}
    //public void CheckLongBottomCake()
    //{
    //    Vector2 raycastDirection = Vector2.down;
    //    RaycastHit2D hit = Physics2D.Raycast(currentPosition + new Vector2(0, -0.5f), raycastDirection, longRaycastDistance, cakeLayerMask);
    //    if (hit.collider != null && hit.collider.CompareTag("Cake"))
    //    {
    //        canMoveDownLong = false;
    //    }
    //    else canMoveDownLong = true;
    //}

    ////for cake
    //public void CheckLongLeftBox()
    //{
    //    Vector2 raycastDirection = Vector2.left;
    //    RaycastHit2D hit = Physics2D.Raycast(currentPosition + new Vector2(-0.5f, 0), raycastDirection, longRaycastDistance, boxLayerMask);
    //    if (hit.collider != null && hit.collider.CompareTag("Box"))
    //    {
    //        canMoveLeftLong = false;
    //    }
    //    else canMoveLeftLong = true;
    //}
    //public void CheckShortLeftBox()
    //{
    //    Vector2 raycastDirection = Vector2.left;
    //    RaycastHit2D hit = Physics2D.Raycast(currentPosition + new Vector2(-0.5f, 0), raycastDirection, shortRaycastDistance, boxLayerMask);
    //    if (hit.collider != null && hit.collider.CompareTag("Box"))
    //    {
    //        canMoveLeftShort = false;
    //    }
    //    else canMoveLeftShort = true;
    //}
    //public void CheckShortRightBox()
    //{
    //    Vector2 raycastDirection = Vector2.right;
    //    RaycastHit2D hit = Physics2D.Raycast(currentPosition + new Vector2(0.5f, 0), raycastDirection, shortRaycastDistance, boxLayerMask);
    //    if (hit.collider != null && hit.collider.CompareTag("Box"))
    //    {
    //        canMoveRightShort = false;
    //    }
    //    else canMoveRightShort = true;
    //}
    //public void CheckLongRightBox()
    //{
    //    Vector2 raycastDirection = Vector2.right;
    //    RaycastHit2D hit = Physics2D.Raycast(currentPosition + new Vector2(0.5f, 0), raycastDirection, longRaycastDistance, boxLayerMask);
    //    if (hit.collider != null && hit.collider.CompareTag("Box"))
    //    {
    //        canMoveRightLong = false;
    //    }
    //    else canMoveRightLong = true;
    //}
    //public void CheckLongTopBox()
    //{
    //    Vector2 raycastDirection = Vector2.up;
    //    RaycastHit2D hit = Physics2D.Raycast(currentPosition + new Vector2(0, 0.5f), raycastDirection, longRaycastDistance, boxLayerMask);
    //    if (hit.collider != null && hit.collider.CompareTag("Box"))
    //    {
    //        canMoveUpLong = false;
    //    }
    //    else canMoveUpLong = true;
    //}
    //public void CheckShortTopBox()
    //{
    //    Vector2 raycastDirection = Vector2.up;
    //    RaycastHit2D hit = Physics2D.Raycast(currentPosition + new Vector2(0, 0.5f), raycastDirection, shortRaycastDistance, boxLayerMask);
    //    if (hit.collider != null && hit.collider.CompareTag("Box"))
    //    {
    //        canMoveUpShort = false;
    //    }
    //    else canMoveUpShort = true;
    //}
}
