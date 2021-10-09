using UnityEngine;

public class PlayerCollideManager : MonoBehaviour
{
    [SerializeField] ScoreManager scoreManager;
    [SerializeField] GameOverManager gameOverManager;

    void OnCollisionEnter(Collision collision)
    {
        // Check if player object hit an obstacle object
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            //Debug.Log("Game Over");
            gameOverManager.SetGameOver();
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        // Check if player object triggered a point collider
        if (other.CompareTag("Point"))
        {
            //Debug.Log("Add Point");
            scoreManager.AddPoint();
        }
    }
}
