using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    public GameController controller;   

    void Start(){
        controller = FindObjectOfType<GameController>();
        if (controller == null)
    {
        Debug.LogError("GameController not found in scene!");
    }
    else
    {
        Debug.Log("GameController found!");
    }
    }
    void OnTriggerEnter2D(Collider2D colisor){
        controller.Score++;
        controller.scoreText.text = controller.Score.ToString();
    }
}
