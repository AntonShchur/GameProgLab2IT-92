
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour
{
    private int score = 0;
    public Text scoring;

    private void Update()
    {
        scoring.text = $"Score: {score}";
        if (score == 6)
        {
            SceneManager.LoadScene("House");
        }
    }
    public void IncreaseScore()
    {
        score += 1;
    }
}
