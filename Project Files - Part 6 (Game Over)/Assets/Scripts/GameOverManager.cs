using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverScreen;
    [SerializeField] Text currentScore;
    [SerializeField] Text finalScore;

    public void SetGameOver()
    {
        gameOverScreen.SetActive(true);

        finalScore.text = currentScore.text;

        currentScore.gameObject.SetActive(false);

        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        Time.timeScale = 1;

        SceneManager.LoadScene(0);
    }
}
