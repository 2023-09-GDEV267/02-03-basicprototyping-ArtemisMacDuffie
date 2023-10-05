using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WeedDefense : MonoBehaviour
{
    public int bedsLost;
    public Text score;
    public GameObject gameOver;

    void Start()
    {
        bedsLost = 0;
    }

    void Update()
    {
        if (bedsLost == 5)
        {
            gameOver.SetActive(true);
            Invoke("Restart", 2f);
        }

        UpdateGUI();
    }

    void UpdateGUI()
    {
        score.text = "Surviving flowerbeds: " + (5 - bedsLost);
    }

    public void LostABed()
    {
        bedsLost++;
    }
    
    private void Restart()
    {
        SceneManager.LoadScene("Main-Prototype 1");
    }
}
