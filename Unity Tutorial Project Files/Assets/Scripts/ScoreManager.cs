using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    Text scoreText;
    int currentScore;

    // Start is called before the first frame update
    void Start()
    {
        // Gets the Text component from our game object
        scoreText = GetComponent<Text>();
    }

    public void AddPoint()
    {
        // Adds 1 to the current score
        currentScore += 1;
        // Updates the score Text component with the current score
        scoreText.text = currentScore.ToString();
    }
}
