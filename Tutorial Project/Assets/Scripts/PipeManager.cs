using UnityEngine;

public class PipeManager : MonoBehaviour
{
    [SerializeField] GameObject bottomPipePrefab;
    [SerializeField] GameObject topPipePrefab;
    [SerializeField] Transform spawnPoint;
    [SerializeField] Vector3 moveSpeed;

    GameObject currentPipe;
    float currentSpawn;
    float spawnHeight;

    // Update is called once per frame
    void Update()
    {
        // If time speed is 0, freeze the game by returning before executing pipe methods
        if (Time.timeScale == 0)
        {
            return;
        }

        // Handles pipe spawning
        PipeSpawner();
        // Handles pipe moving
        PipeMover();
    }

    void PipeSpawner()
    {
        // Check if it's time to spawn another pipe
        if (Time.time > currentSpawn)
        {
            // Set pipe's spawn height
            SpawnHeight();
            // Set pipe's spawn direction
            PipeDirection();
            //Debug.Log("Spawn Pipe");
            Instantiate(currentPipe, new Vector3(spawnPoint.position.x, spawnHeight, spawnPoint.position.z), Quaternion.identity, transform);
            // Add 2 seconds before spawning another pipe
            currentSpawn = Time.time + 2;
        }
    }

    void PipeDirection()
    {
        // Pick a random direction (0 = bottom, 1 = top)
        int directionIndex = Random.Range(0, 2);
        // If random direction is 0, set current pipe to bottomPipePrefab
        if (directionIndex == 0)
        {
            currentPipe = bottomPipePrefab;
        }
        // If random direction is 1, set current pipe to topPipePrefab
        else
        {
            currentPipe = topPipePrefab;
        }
    }

    void SpawnHeight()
    {
        // Sets a random height for the current pipe
        spawnHeight = Random.Range(-2.0f, 4.0f);
    }

    void PipeMover()
    {
        // Moves the parent object that contains all spawned pipes
        transform.position += moveSpeed;
    }
}
