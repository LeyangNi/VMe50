using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EndingText : MonoBehaviour
{
    public GameObject amount;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (amount.GetComponent<TargetAmount>().amount == 0)
        {
            GetComponent<TMPro.TextMeshPro>().text = "Congratulations! You hit all the targets!";
        }
    }
}
