using UnityEngine;

public class PlayerCollideManager : MonoBehaviour
{
    [SerializeField] ScoreManager scoreManager;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over");

            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Point"))
        {
            Debug.Log("Add Point");

            scoreManager.AddPoint();
        }
    }
}
