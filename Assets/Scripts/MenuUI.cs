using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI highScoreText;

    void Start()
    {
        if (PlayerPrefs.HasKey("highscore"))
            highScoreText.text = PlayerPrefs.GetFloat("highscore").ToString();
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
