using System.Collections;   
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float speed = -10.0f;
    private float lowerBound = -10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // If animal goes past the bottom boundary (out of bounds)
        if (transform.position.z < lowerBound)
        {
            GameObject.Find("SpawnManager").GetComponent<SpawnManager>().UpdateLives(-1);
            Destroy(gameObject);
        }
    }
}
