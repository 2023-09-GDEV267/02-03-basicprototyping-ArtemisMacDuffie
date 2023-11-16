using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeedBomb : MonoBehaviour
{
    public static float bottom = -9f;

    void Update()
    {
        if (transform.position.y < bottom)
        {
            Destroy(this.gameObject);
        }
    }
}
