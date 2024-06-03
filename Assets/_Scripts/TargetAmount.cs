using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetAmount : MonoBehaviour
{
    public int amount = 8;

    public GameObject src; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        src.GetComponent<TMPro.TextMeshPro>().text = "Targets Left: " + amount.ToString();
    }
}
