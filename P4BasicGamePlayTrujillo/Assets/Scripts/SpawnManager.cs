using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefab;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    public int score = 0;
    public int lives = 3;
    public float speed = 40.0f;
    private float lowerBound = -10.0f;

    void Start()
    {
        // Existing invokes...
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);

        // Log initial stats
        Debug.Log("Lives = " + lives);
        Debug.Log("Score = " + score);
    }

    // Create a method we can call from other scripts
    public void UpdateScore(int amount)
    {
        score += amount;
        Debug.Log("Score = " + score);
    }

    public void UpdateLives(int amount)
    {
        lives += amount;
        Debug.Log("Lives = " + lives);

        if (lives <= 0)
        {
            Debug.Log("Game Over");
        }
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (transform.position.z < lowerBound)
        {
            GameObject.Find("SpawnManager").GetComponent<SpawnManager>().UpdateLives(-1);
            Destroy(gameObject);
        }
    }
    void SpawnLeftAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefab.Length);
        Vector3 spawnPos = new Vector3(-spawnRangeX, 0, Random.Range(5, 15));
        // Rotate 90 degrees to face right
        Vector3 rotation = new Vector3(0, 90, 0);

        Instantiate(animalPrefab[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }

    // Spawns animal from the right side, facing left
    void SpawnRightAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefab.Length);
        Vector3 spawnPos = new Vector3(spawnRangeX, 0, Random.Range(5, 15));
        // Rotate -90 degrees to face left
        Vector3 rotation = new Vector3(0, -90, 0);

        Instantiate(animalPrefab[animalIndex], spawnPos, Quaternion.Euler(rotation));

    }
}