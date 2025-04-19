using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject gameOverScreen;
    [SerializeField] ScoreManager sm;
    [SerializeField] ParticleSystem deathWishes;

    public void GameOver()
    {
        Time.timeScale = 0.1f;
        StartCoroutine(GameOverRoutine());
    }

    IEnumerator GameOverRoutine()
    {
        deathWishes.Play();
        yield return new WaitForSeconds(0.3f);
        Time.timeScale = 0;
        PlayerPrefs.SetFloat("highscore", sm.GetScore());
        sm.SetCanScore(false);
        gameOverScreen.SetActive(true);
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void BackBtn()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    
}
