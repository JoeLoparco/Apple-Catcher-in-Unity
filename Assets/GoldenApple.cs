using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldenApple : MonoBehaviour
{
    public static float bottomY = -20f;
    private ScoreCounter scoreCounter; 
    void Start()
    {
        scoreCounter = GameObject.FindObjectOfType<ScoreCounter>();
        if (scoreCounter == null)
        {
            Debug.LogError("ScoreCounter Not Found In GoldenApple.cs");
        }
    }
    void Update()
    {
       if (transform.position.y < bottomY) {
            scoreCounter.applesMissed ++;
            Destroy (this.gameObject);
       } 
    }
}
