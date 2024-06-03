using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Transformers;
using UnityEngine.XR.Interaction.Toolkit.Utilities;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Pooling;

public class Detector : MonoBehaviour
{
    public GameObject textObject; // The text GameObject to be disabled
    private XRGrabInteractable grabInteractable;

    void Awake()
    {
        grabInteractable = GetComponent<XRGrabInteractable>();

        if (grabInteractable == null)
        {
            Debug.LogError("XR Grab Interactable not found!");
        }

        if (textObject == null)
        {
            Debug.LogError("Text Object not assigned!");
        }
    }

    void OnEnable()
    {
        grabInteractable.selectEntered.AddListener(OnSelectEntered);
    }

    void OnDisable()
    {
        grabInteractable.selectEntered.RemoveListener(OnSelectEntered);
    }

    private void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (textObject != null)
        {
            textObject.SetActive(false); // Disable the text object
        }
        // Destroy the pickup object

    }
}