using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WeedDefense : MonoBehaviour
{
    public int bedsLost;
    public Text score;
    public Text currentTime;
    public GameObject gameOver;
    private string lifespan;
    private bool defeat;

    void Start()
    {
        bedsLost = 0;
        defeat = false;
        UpdateGUI();
    }

    void Update()
    {
        if (bedsLost == 5 && !defeat)
        {
            gameOver.SetActive(true);
            defeat = true;
            lifespan = "Time survived: " + string.Format("{0:0.00}", Time.time) + "s";
            Invoke("Restart", 2f);
        }

        UpdateGUI();
    }

    void UpdateGUI()
    {
        score.text = "Surviving flowerbeds: " + (5 - bedsLost);

        if (defeat)
        {
            currentTime.text = lifespan;
        }
        else
        {
            currentTime.text = "Time survived: " + string.Format("{0:0.00}", Time.time) + "s";
        }
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
