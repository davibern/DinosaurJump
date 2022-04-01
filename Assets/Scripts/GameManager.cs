using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject gameStartPanel;
    private AudioSource loseSound;

    // Start is called before the first frame update
    void Start()
    {
            Time.timeScale = 0;
    }

    public void GameStart()
    {
        Time.timeScale = 1;
        loseSound = GetComponent<AudioSource>();
        gameStartPanel.SetActive(false);
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
        loseSound.Play();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }

}
