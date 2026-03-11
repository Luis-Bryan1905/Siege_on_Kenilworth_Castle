using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    int score = 0;

    Text scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreText = this.GetComponent<Text>();
        scoreText.text = "Score: 000";
    }

    void UpdateText()
    {
        scoreText.text = "Score: " + score.ToString();
    }

    public void AddPoint(int ScoreAmount)
    {
        score += ScoreAmount;
        UpdateText();
    }
}
