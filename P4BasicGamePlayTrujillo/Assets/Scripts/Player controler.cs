using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 10.0f;
    public float verticalInput;
    public float zMin;
    public float zMax;
    public Transform projectileSpawnPoint;
    public GameObject projectilePrefab;
    
    void Start()
    {

    }

    
    void Update()
    {
        Instantiate(projectilePrefab, projectileSpawnPoint.position, projectilePrefab.transform.rotation);

        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

       

        
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        
        if (transform.position.z < -zMin)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zMin);
        }
        if (transform.position.z > zMax)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMax);
        }

      
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}