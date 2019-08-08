using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePositionTracker : MonoBehaviour
{
    public float mouseX;
    public float mouseY;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        ConvertMousePositionToZeroOne();
    }

    private void ConvertMousePositionToZeroOne()
    {
        mouseX = Input.mousePosition.x / Screen.width;
        mouseY = Input.mousePosition.y / Screen.height;
    }
}
