using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour
{
    // Start is called before the first frame update
    public static float bottomY = -20f;
    private ScoreCounter scoreCounter; 

    // Update is called once per frame
    void Start()
    {
        scoreCounter = GameObject.FindObjectOfType<ScoreCounter>();
        if (scoreCounter == null)
        {
            Debug.LogError("ScoreCounter Not Found In Apple.cs");
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
