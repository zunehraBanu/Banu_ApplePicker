using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject applePrefab;
    public GameObject badApplePrefab;   // <-- Black Apple

    public float speed = 4f;
    public float leftAndRightEdge = 28f;

    [Range(0f, 1f)]
    public float changeDirChance = 0.1f;

    public float appleDropDelay = 1f;

    [Header("Bad Apple Settings")]
    [Range(0f, 1f)]
    public float badAppleChance = 0.1f; // 10% chance

    void Start()
    {
        Invoke("DropApple", appleDropDelay);
    }

    void DropApple()
    {
        GameObject prefabToDrop = applePrefab;

        // Occasionally drop a black apple
        if (badApplePrefab != null && Random.value < badAppleChance)
        {
            prefabToDrop = badApplePrefab;
        }

        GameObject apple = Instantiate<GameObject>(prefabToDrop);
        apple.transform.position = transform.position;

        Invoke("DropApple", appleDropDelay);
    }

    void Update()
    {
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        if (pos.x < -leftAndRightEdge)
        {
            speed = Mathf.Abs(speed);
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed);
        }
    }

    void FixedUpdate()
    {
        if (Random.value < changeDirChance)
        {
            speed *= -1;
        }
    }
}
