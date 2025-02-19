using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    [SerializeField] public ScoreCounter scoreCounter; // Create score counter
    private bool initialized = false;
    
    void Start()
    {
        // Find a GameObject named ScoreCounter in the Scene Hierarchy
        GameObject scoreGO = GameObject.Find("ScoreCounter");
        Debug.Log("Found ScoreCounter GameObject: " + scoreGO);
        scoreCounter = scoreGO.GetComponent<ScoreCounter>();
        Debug.Log("Got ScoreCounter component: " + scoreCounter);
        initialized = true;
    }

    void OnCollisionEnter(Collision coll)
    {
        GameObject collidedWith = coll.gameObject;
        if(collidedWith.CompareTag("Apple"))
        {
            Debug.Log($"Basket {GetInstanceID()} pre-score update - scoreCounter is: {scoreCounter}");
            Destroy(collidedWith);
            if (scoreCounter != null)
            {
                scoreCounter.score += 100;
            }
            else
            {
                Debug.LogError($"Basket {GetInstanceID()} - scoreCounter is null at point of score update!");
            }
        }else if(collidedWith.CompareTag("GoldenApple"))
        {
            Debug.Log($"Basket {GetInstanceID()} pre-score update - scoreCounter is: {scoreCounter}");   
            Destroy(collidedWith);
            if (scoreCounter != null)
            {
                scoreCounter.score += 500;
            }
            else
            {
                Debug.LogError($"Basket {GetInstanceID()} - scoreCounter is null at point of score update!");
            }
        }
    }

    void Update()
    {
        // Get current screen position of Mouse
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }
}