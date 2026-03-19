using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefab;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
        InvokeRepeating("SpawnLeftAnimal", 3, 2.5f);  // Starts after 3s, every 2.5s
        InvokeRepeating("SpawnRightAnimal", 4, 3.0f); // Starts after 4s, every 3.0s
    }

    // Update is called once per frame
    void Update()
    {

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