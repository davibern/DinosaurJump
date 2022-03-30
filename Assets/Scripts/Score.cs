using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int score;
    private Text scoreText;
    public Text highScoreText;
    private float timer;
    private float maxTime;
    private AudioSource scoreSound;

    // Start is called before the first frame update
    void Start()
    {
        highScoreText.text = "HI " + PlayerPrefs.GetInt("highscore", 0).ToString("00000");
        score = 0;
        scoreText = GetComponent<Text>();
        maxTime = 0.1f;
        scoreSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= maxTime)
        {
            score++;
            scoreText.text = score.ToString("00000");
            timer = 0;

            if (score % 100 == 0)
            {
                scoreSound.Play();
                Time.timeScale += 0.1f;
            }
        }

        if (Time.timeScale == 0)
        {
            if (score > PlayerPrefs.GetInt("highscore", 0))
            {
                PlayerPrefs.SetInt("highscore", score);
                highScoreText.text = "HI " + PlayerPrefs.GetInt("highscore", 0).ToString("00000");
            }
        }
    }
}
