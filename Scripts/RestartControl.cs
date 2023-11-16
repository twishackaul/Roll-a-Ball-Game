using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartControl : MonoBehaviour
{

    public GameObject restartUI;

    void Start()
    {
        restartUI.SetActive(false);
    }

    public void Restart()
    {
        restartUI.SetActive(true);
    }
    
    public void ResetTheGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

  
}
