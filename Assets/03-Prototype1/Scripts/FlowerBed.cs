using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerBed : MonoBehaviour
{
    [Header("Set in inspector")]
    public GameObject weedbedPrefab;

    private GameObject newWeeds;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bomb"))
        {
            WeedDefense weedScript = Camera.main.GetComponent<WeedDefense>();
            weedScript.LostABed();
            newWeeds = Instantiate(weedbedPrefab);
            newWeeds.transform.position = this.transform.position;
            this.gameObject.SetActive(false);
            Destroy(other.gameObject);
        }
    }
}
