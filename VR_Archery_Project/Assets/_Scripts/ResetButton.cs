using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;

public class ResetButton : MonoBehaviour
{
    bool restart;
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        restart = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && !restart)
        {
            restart = true;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
