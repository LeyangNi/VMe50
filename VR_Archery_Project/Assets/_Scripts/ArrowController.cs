using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ArrowController : MonoBehaviour
{
    [SerializeField]
    private GameObject midPointVisual, arrowPrefab, arrowSpawnPoint;

    [SerializeField]
    private float arrowMaxSpeed = 10;

    [SerializeField]
    private TextMeshProUGUI counterText;

    [SerializeField]
    private AudioSource bowReleaseAudioSource;

    public int count = 0;

    private void Start()
    {
        // Initialize the counter text
        UpdateCounterText();
    }

    public void PrepareArrow()
    {
        midPointVisual.SetActive(true);
    }

    public void ReleaseArrow(float strength)
    {
        bowReleaseAudioSource.Play();
        midPointVisual.SetActive(false);

        GameObject arrow = Instantiate(arrowPrefab);

        count = count + 1;
        UpdateCounterText();

        arrow.transform.position = arrowSpawnPoint.transform.position;
        arrow.transform.rotation = midPointVisual.transform.rotation;
        Rigidbody rb = arrow.GetComponent<Rigidbody>();
        rb.AddForce(midPointVisual.transform.forward * strength * arrowMaxSpeed, ForceMode.Impulse);

    }

    private void UpdateCounterText()
    {
        // Debug log to ensure the method is called
        Debug.Log("Updating counter text to: " + count);

        // Update the text to reflect the current count
        counterText.text = "Arrows Shot: " + count.ToString();

        // Debug log to show current text value
        Debug.Log("Counter text set to: " + counterText.text);
    }
}
