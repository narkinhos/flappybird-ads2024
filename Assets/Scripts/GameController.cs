using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{

    public int Score;
    public Text scoreText;
    void Start(){
        Time.timeScale = 1;
        Debug.Log("Restarting game...");
    }
        
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }

}
