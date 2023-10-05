using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WeedDefense : MonoBehaviour
{
    public int bedsLost;
    public Text score;

    void Start()
    {
        bedsLost = 0;
    }

    void Update()
    {
        if (bedsLost == 5)
        {
            SceneManager.LoadScene("Main-Prototype 1");
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
}
