using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine;

public class pad1script : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        getgrabbed.OnGrabbed += Activate;
        getgrabbed.OnReleased += Deactivate;
    }

    void OnDisable()
    {
        getgrabbed.OnGrabbed -= Activate;
        getgrabbed.OnReleased -= Deactivate;
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
