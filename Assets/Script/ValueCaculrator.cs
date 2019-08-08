using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueCaculrator : MonoBehaviour
{
    public MousePositionTracker manager;

    [SerializeField]
    private float minPositionX;
    [SerializeField]
    private float maxPositionX;

    [Range(0, 1)]
    public float slider;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Lerp(minPositionX, maxPositionX, manager.mouseX), transform.position.y, transform.position.z);
    }

    void CaculatePosition()
    {

    }
}
