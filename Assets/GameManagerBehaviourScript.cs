using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerBehaviourScript : MonoBehaviour
{
    public GameObject restartButton;
    public GameObject gameOverImage;
    public GameObject gameOverImage2;
    public GameObject startButton;

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
}
