using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;

    public int playerScore = 0;
    public int computerScore = 0;

    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI computerScoreText;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);
    }

    public void AddPlayerScore()
    {
        playerScore++;
        UpdateScoreUI();
    }

    public void AddComputerScore()
    {
        computerScore++;
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        if (playerScoreText != null)
            playerScoreText.text = playerScore.ToString();
        if (computerScoreText != null)
            computerScoreText.text = computerScore.ToString();
    }
}
