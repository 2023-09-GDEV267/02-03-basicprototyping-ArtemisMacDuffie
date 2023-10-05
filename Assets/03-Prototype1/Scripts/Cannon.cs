using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    [Header("Set in inspector")]
    public GameObject bombPrefab;
    public int minPow = 1;
    public int maxPow = 10;
    public float shootChance = 0.01f;
    public float minTimeBetweenShots = 0.5f;

    [Header("Set dynamically")]
    public Vector3 launchPos;
    public Vector3 launchAngle;
    private Rigidbody bombBody;
    private GameObject weedBomb;
    private float timeSinceLastShot;

    void Start()
    {
        launchPos = transform.position;
        launchAngle.x = 1;
        launchAngle.y = 1;
        launchAngle.z = 0;
        timeSinceLastShot = 0f;
    }

    void FixedUpdate()
    {
        if (Random.value < shootChance
            && timeSinceLastShot > minTimeBetweenShots)
        {
            weedBomb = Instantiate(bombPrefab);
            weedBomb.transform.position = launchPos;
            int power = Random.Range(minPow, maxPow);
            bombBody = weedBomb.GetComponent<Rigidbody>();
            bombBody.velocity = launchAngle * power;
            weedBomb = null;
            timeSinceLastShot = 0f;
        }
        else
        {
            timeSinceLastShot += Time.deltaTime;
        }
    }
}
