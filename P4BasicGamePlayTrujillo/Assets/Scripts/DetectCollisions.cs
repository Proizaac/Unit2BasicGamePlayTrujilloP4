using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    private SpawnManager spawnManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Find the SpawnManager object in the scene
        spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Hit by animal: lose a life
            spawnManager.UpdateLives(-1);
            Destroy(gameObject);
        }
        else if (other.CompareTag("Projectile"))
        {
            // Fed the animal: gain score
            spawnManager.UpdateScore(1);
            Destroy(gameObject);
            Destroy(other.gameObject);
        }

        // Update is called once per frame
        void Update()
        {

        }

        void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                Debug.Log("Game Over!");
                // Optional: Destroy(other.gameObject); to remove the player
            }
            // Destroy the projectile if it hits the animal
            else if (other.CompareTag("Projectile"))
            {
                Destroy(gameObject);
                Destroy(other.gameObject);
            }
        }
    }
}