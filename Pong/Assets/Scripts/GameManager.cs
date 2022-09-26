using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int _playerScore;
    private int _computerScore;
    public Ball ball;
    public Text playerScoreText;
    public Text computerScoreText;

    public void PlayerScore()
    {
        _playerScore++;

        playerScoreText.text = _playerScore.ToString();
        this.ball.ResetPosition();
    }

    public void ComputerScore()
    {
        _computerScore++;

        computerScoreText.text = _computerScore.ToString();
        this.ball.ResetPosition();
    }


}
