using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] float scoreMultiplier = 1.5f;

    float score;

    void Update()
    {
        score += Time.time * scoreMultiplier;
        scoreText.text = "Score : " + score.ToString("F0");
    }
}
