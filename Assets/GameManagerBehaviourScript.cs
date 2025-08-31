using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManagerBehaviourScript : MonoBehaviour
{
    public GameObject restartButton;
    public GameObject gameOverImage;
    public GameObject gameOverImage2;
    public GameObject startButton;
    public TextMeshProUGUI scoreText;
    private float score = 0f;
    private bool isPlaying = true;

    private void Start()
    {
        Time.timeScale = 0f;
    }
    public void GameOver()
    {
        restartButton.SetActive(true);
        gameOverImage.SetActive(true);
        gameOverImage2.SetActive(true);
        Time.timeScale = 0f;
    }

    public void RestartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void StartGame()
    {
        Time.timeScale = 1f;
        startButton.SetActive(false);
    }

    public void StopScore()
    {
        isPlaying = false;
    }
    public void RestartScore() 
    { 
        isPlaying = true;
        score = 0f;
    }

    private void Update()
    {
        if (isPlaying)
        {
            score += Time.deltaTime * 10;
            scoreText.text = "Score: " + Mathf.FloorToInt(score).ToString();
        }
    }
}
