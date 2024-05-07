using System.Collections;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D rig;
    public GameObject explosionPrefab;
    public GameObject gameOverScreen;
    private Renderer renderer;
    private AudioSource audioSource;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        renderer = GetComponent<Renderer>();
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rig.velocity = Vector2.up * speed;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Torna a nave invisível
        renderer.enabled = false;

        // Mostra a tela de Game Over
        gameOverScreen.SetActive(true);

        // Instancia a explosão na posição da colisão
        Instantiate(explosionPrefab, collision.GetContact(0).point, Quaternion.identity);

        // Reproduz o áudio da colisão
        if (audioSource != null && audioSource.clip != null)
        {
            audioSource.Play();
        }

        // Inicia uma rotina para pausar o jogo após 1 segundo
        StartCoroutine(PauseAfterDelay(1f));
    }

    IEnumerator PauseAfterDelay(float delay)
    {
        // Espera pelo atraso especificado
        yield return new WaitForSecondsRealtime(delay);

        // Pausa o jogo
        Time.timeScale = 0;
    }
}
