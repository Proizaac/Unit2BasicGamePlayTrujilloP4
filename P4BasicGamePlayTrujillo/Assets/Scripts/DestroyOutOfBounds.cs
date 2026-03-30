using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float lowerBound = -10.0f;

    private float leftBound = -30.0f;
    private float rightBound = 30.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        // Check for Top and Lower bounds (on the z-axis)
        if (transform.position.z > topBound)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
        // Check for Left and Right bounds (on the x-axis)
        else if (transform.position.x < leftBound)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
        else if (transform.position.x > rightBound)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }
}
