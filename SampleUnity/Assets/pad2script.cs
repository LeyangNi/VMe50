using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine;

public class pad2script : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        getgrabbed.OnGrabbed += Deactivate;
        getgrabbed.OnReleased += Activate;
    }

    void OnDisable()
    {
        getgrabbed.OnGrabbed -= Deactivate;
        getgrabbed.OnReleased -= Activate;
    }

    void Deactivate()
    {
        // deactivate childrend of the game object
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(false);
        }
    }

    void Activate()
    {
        // activate childrend of the game object
        foreach (Transform child in transform)
        {
            child.gameObject.SetActive(true);
        }
    }
}
