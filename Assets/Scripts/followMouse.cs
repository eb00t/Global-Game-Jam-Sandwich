using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followMouse : MonoBehaviour
{
    //public Texture2D cursorTexture;

    [SerializeField] private Camera mainCamera;

    void Start()
    {
    }
    

    public void Update()
    {
        Vector3 mouseWorldPosition = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        mouseWorldPosition.z = 0f;
        transform.position = mouseWorldPosition;
    }

    

    public void OnMouseDown()
    {
        //use keiths rb code, onclick rb activate/ play anim + if touch box destroy
    }
}
