using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    public GameObject applePrefab;
    public float speed = 1f;
    public float leftAndRightEdge = 10f;
    public float chanceToChangeDirections = 0.1f;
    public float secondsBetweenAppleDrops = 1f;

    void Start()
    {
        
    }

    void Update()
    {
        //hitting edge of screen
        Vector3 position = transform.position;
        position.x += speed * Time.deltaTime;
        transform.position = position;

        if (position.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (position.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
    }

    private void FixedUpdate()
    {
        //random direction change
        if (Random.value < chanceToChangeDirections)
        {
            speed *= -1;
        }
    }
}
