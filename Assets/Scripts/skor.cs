using UnityEngine;
using UnityEngine.UI;

public class skor : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    void Start()
    {
        // Ba�lang��ta skoru ekrana yazd�r
        UpdateScoreText();
    }

    // Skoru art�rmak i�in bu fonksiyonu �a��rabilirsiniz
    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    // Skoru ekrana yazd�rmak i�in bu fonksiyonu �a��rabilirsiniz
     void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();

    }
}
