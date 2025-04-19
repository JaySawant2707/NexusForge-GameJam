using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI highScoreText;

    void Start()
    {
        if (PlayerPrefs.HasKey("highscore"))
            highScoreText.text = "Highscore\n" + PlayerPrefs.GetFloat("highscore").ToString("F0");
    }
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
