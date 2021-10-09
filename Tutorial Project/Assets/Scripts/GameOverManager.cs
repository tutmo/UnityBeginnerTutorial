using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverWindow;
    [SerializeField] Text currentScore;
    [SerializeField] Text finalScore;

    public void SetGameOver()
    {
        // Show game over window
        gameOverWindow.SetActive(true);
        // Get final score
        finalScore.text = currentScore.text;
        // Stop score counter
        currentScore.gameObject.SetActive(false);
        // Stop time
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        // Start time
        Time.timeScale = 1f;
        // Restart scene
        SceneManager.LoadScene(0);
    }
}
