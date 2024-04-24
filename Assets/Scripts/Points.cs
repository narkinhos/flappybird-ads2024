using UnityEngine;

public class Points : MonoBehaviour
{
    public GameManager gameManager;

    private void Start()
    {
        if (gameManager == null) {
            var obj = GameObject.FindWithTag("GameController");
            gameManager = obj.GetComponent<GameManager>();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameManager.Score++;
    }
}
