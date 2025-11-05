using UnityEngine;

public class SpawnSphereOnClick : MonoBehaviour
{
    public GameObject spherePrefab;  
    public float minX = -10f;        
    public float maxX = 10f;         
    public float spawnY = 20f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SpawnBall();
        }
    }

    void SpawnBall()
    {
        float randomX = Random.Range(minX, maxX);
        float randomZ = Random.Range(minZ, maxZ);
        Vector3 spawnPosition = new Vector3(randomX, spawnY, randomZ);
        Instantiate(spherePrefab, spawnPosition, Quaternion.identity);
    }
}