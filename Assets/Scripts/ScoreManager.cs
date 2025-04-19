using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] float scoreMultiplier = 1.5f;

    float score;
    bool canScore = true;

    void Update()
    {
        if (canScore)
        {
            score += Time.time * scoreMultiplier;
            scoreText.text = "Score : " + score.ToString("F0");
        }
    }

    public float GetScore()
    {
        return score;
    }

    public void SetCanScore(bool value)
    {
        canScore = value;
    }
}
