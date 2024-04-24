using UnityEngine;

public class Health : MonoBehaviour
{
    public GameManager gameManager;

    private void Start()
    {
        if (gameManager == null) {
            var obj = GameObject.FindWithTag("GameController");
            gameManager = obj.GetComponent<GameManager>();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameIsOver();
    }
}
