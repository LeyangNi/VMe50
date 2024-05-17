using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changecolor : MonoBehaviour
{
    void Start()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }
    
    void OnEnable()
    {
        getgrabbed.OnGrabbed += ChangeColor;
        getgrabbed.OnReleased += ChangeColorBack;
    }

    void OnDisable()
    {
        getgrabbed.OnGrabbed -= ChangeColor;
        getgrabbed.OnReleased -= ChangeColorBack;
    }

    void ChangeColor()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }

    void ChangeColorBack()
    {
        GetComponent<Renderer>().material.color = Color.blue;
    }
}
