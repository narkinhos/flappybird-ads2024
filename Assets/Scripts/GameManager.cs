using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Text scoreView;
    [SerializeField] private GameObject gameOverView;

    private int _score;

    public int Score
    {
        get => _score;
        set
        {
            scoreView.text = value.ToString();
            _score = value;
        }
    }

    private void Start()
    {
        Time.timeScale = 1;
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void GameIsOver()
    {
        gameOverView.SetActive(true);
        Time.timeScale = 0;
    }
}
