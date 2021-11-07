using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    [SerializeField] GameObject bottomPipePrefab;
    [SerializeField] GameObject topPipePrefab;
    [SerializeField] Transform spawnPoint;

    GameObject currentPipe;
    float currentSpawnTime;
    float spawnHeight;

    // Update is called once per frame
    void Update()
    {
        SpawnPipe();
    }

    void SpawnPipe()
    {
        if (Time.time > currentSpawnTime)
        {
            Debug.Log("Spawn Pipe!");

            SpawnHeight();

            PipeDirection();

            Instantiate(currentPipe, new Vector3(spawnPoint.position.x, spawnHeight, spawnPoint.position.z), Quaternion.identity, transform);

            currentSpawnTime = Time.time + 2;
        }
    }

    void SpawnHeight()
    {
        spawnHeight = Random.Range(-2.0f, 4.0f);
    }

    void PipeDirection()
    {
        int directionIndex = Random.Range(0, 2);

        if (directionIndex == 0)
        {
            currentPipe = bottomPipePrefab;
        }
        else
        {
            currentPipe = topPipePrefab;
        }
    }
}
