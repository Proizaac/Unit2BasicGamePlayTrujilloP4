using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefab;
    public float sideSpawnMinZ;
    public float sideSpawnMaxZ;
    public float sideSpawnX;
  
    
    void Start()
    {
       
    }

   
    void Update()
    {
       
    }
    void SpawnLeftAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefab.Length);
        Vector3 spawnPos = new Vector3(-sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ));

        Vector3 rotation = new Vector3(0, 90, 0);

        Instantiate(animalPrefab[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }

 
    void SpawnRightAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefab.Length);
        Vector3 spawnPos = new Vector3(sideSpawnX, 0, Random.Range(sideSpawnMinZ, sideSpawnMaxZ)); 
       
        Vector3 rotation = new Vector3(0, -90, 0);

        Instantiate(animalPrefab[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }
}