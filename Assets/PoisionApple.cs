using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisionApple : MonoBehaviour
{
    public static float bottomY = -20f;
    private ScoreCounter scoreCounter; 

    void Start()
    {
        scoreCounter = GameObject.FindObjectOfType<ScoreCounter>();
        if (scoreCounter == null)
        {
            Debug.LogError("ScoreCounter Not Found In PoisonApple.cs");
        }
    }
    void Update()
    {
       if (transform.position.y < bottomY) {
            Destroy (this.gameObject);
       } 
    }
}