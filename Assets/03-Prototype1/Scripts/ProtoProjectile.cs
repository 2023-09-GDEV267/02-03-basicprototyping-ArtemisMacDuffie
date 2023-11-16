using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtoProjectile : MonoBehaviour
{
    [HideInInspector]
    private float startTime;
    public bool launched;
    public bool firstUpdate;

    void Start()
    {
        launched = false;
        firstUpdate = false;
    }

    void Update()
    {
        if (launched)
        {
            float currentTime = Time.time;
            float lifetime = currentTime - startTime;

            if (lifetime > 10)
            {
                Destroy(this.gameObject);
            }
        }
        else if (firstUpdate)
        {
            firstUpdate = false;
            launched = true;
            startTime = Time.time;
        }
        
    }
}
