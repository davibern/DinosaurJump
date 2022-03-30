using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;
    private AudioSource loseSound;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        loseSound = GetComponent<AudioSource>();
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
