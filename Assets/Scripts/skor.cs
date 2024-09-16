using UnityEngine;
using UnityEngine.UI;

public class skor : MonoBehaviour
{
    public Text scoreText;
    private int score = 0;

    void Start()
    {
        // Baþlangýçta skoru ekrana yazdýr
        UpdateScoreText();
    }

    // Skoru artýrmak için bu fonksiyonu çaðýrabilirsiniz
    public void IncreaseScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    // Skoru ekrana yazdýrmak için bu fonksiyonu çaðýrabilirsiniz
     void UpdateScoreText()
    {
        scoreText.text = "Score: " + score.ToString();

    }
}
